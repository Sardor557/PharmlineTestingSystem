using AsbtCore.UtilsV2;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using PharmlineCRMSystem.Shared.Services;
using PharmlineTestingSystem.Database;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Repository.Services
{
    public sealed class UserService : IUserService
    {
        private readonly MyDbContext db;
        private readonly IConfiguration conf;
        private readonly ILogger<UserService> logger;
        private readonly IHttpContextAccessorExtensions accessor;

        public UserService(MyDbContext db, IConfiguration conf, IHttpContextAccessorExtensions accessor, ILogger<UserService> logger)
        {
            this.db = db;
            this.conf = conf;
            this.accessor = accessor;
            this.logger = logger;
        }

        private viUser GetToken(tbUser res)
        {
            var SecretStr = conf["SystemParams:PrivateKeyString"];
            var key = Encoding.ASCII.GetBytes(SecretStr);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                           {
                               new Claim(ClaimTypes.Sid, res.Id.ToString()),
                               new Claim(ClaimTypes.Name, $"{res.FIO}"),
                               new Claim(ClaimTypes.NameIdentifier, res.Login.ToString()),
                           }),
                Expires = DateTime.Now.AddDays(365),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            var usr = new viUser();
            usr.Id = res.Id;
            usr.Token = tokenHandler.WriteToken(token);
            usr.Login = res.Login;
            usr.FIO = res.FIO;

            return usr;
        }

        public async Task<Answer<viUser>> CreateUserAsync(viUserRegister value)
        {
            tbUser res = await db.tbUsers.AsNoTracking()
                                         .FirstOrDefaultAsync(x => x.Login == value.Login);

            if (res == null)
            {
                res = new tbUser
                {
                    FIO = value.Name,
                    Login = value.Login,
                    Password = CHash.EncryptMD5(value.Password),
                    CreateDate = DateTime.Now,
                    CreateUser = accessor.GetId(),
                    Status = 1
                };

                await db.tbUsers.AddAsync(res);
                await db.SaveChangesAsync();

                res = await db.tbUsers
                              .Where(x => x.Login == value.Login)
                              .FirstOrDefaultAsync();
            }
            else
            {
                if (res.Password != value.Password)
                    return new Answer<viUser>(false, "Бундай фойдаланувчи тизимда бор", null);
            }


            return new Answer<viUser>(true, "", GetToken(res));
        }

        public async Task<Answer<viUser>> AuthenticateAsync(viAuthenticateModel model, string ip)
        {
            var hash = CHash.EncryptMD5(model.Password);
            var res = await db.tbUsers
                              .AsNoTracking()
                              .Where(x => x.Login == model.Login && x.Password == hash)
                              .FirstOrDefaultAsync();

            if (res == null)
            {
                logger.LogError($"Пользователь не найден {model} Ip:{ip}");
                return new Answer<viUser>(false, "Неправильный логин или пароль", null);
            }

            return new Answer<viUser>(true, "", GetToken(res));
        }

        public async Task<AnswerBasic> UpdateAsync(viUser user)
        {
            var u = await db.tbUsers.FindAsync(user.Id);
            u.FIO = user.FIO;
            await db.SaveChangesAsync();

            return new AnswerBasic(true, "");
        }

        public async Task<AnswerBasic> ChangePasswordAsync(SetProperty<int, string> p)
        {
            var u = await db.tbUsers.FindAsync(p.Id);
            u.Password = CHash.EncryptMD5(p.Value);
            await db.SaveChangesAsync();

            return new AnswerBasic(true, "");
        }

        public async Task<Answer<tbUser>> GetByIdAsync(int id)
        {
            var res = await db.tbUsers.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
            res.Password = null;
            return new Answer<tbUser>(true, "", res);
        }

        public async Task<Answer<tbUser[]>> GetAllUsersAsync()
        {
            var ls = await db.tbUsers.AsNoTracking().ToArrayAsync();
            foreach (var it in ls)
            {
                it.Password = null;
            }

            return new Answer<tbUser[]>(true, "", ls);
        }

        public async Task<Answer<viUser>> SetUserStatusAsync(SetProperty<int, int> model)
        {
            var res = await db.tbUsers.FirstOrDefaultAsync(x => x.Id == model.Id);
            res.Status = model.Value;
            await db.SaveChangesAsync();

            return new Answer<viUser>(true, "", new viUser() { FIO = res.FIO, Id = res.Id, Login = res.Login });
        }
    }
}
