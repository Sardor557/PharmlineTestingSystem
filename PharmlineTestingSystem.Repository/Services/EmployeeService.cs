using PharmlineTestingSystem.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using PharmlineTestingSystem.Database;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Repository.Services
{
    public sealed class EmployeeService : IEmployeeService
    {
        private readonly ILogger<EmployeeService> logger;
        private readonly MyDbContext db;
        private readonly IConfiguration conf;

        public EmployeeService(ILogger<EmployeeService> logger, MyDbContext db, IConfiguration conf)
        {
            this.logger = logger;
            this.db = db;
            this.conf = conf;
        }

        private viEmployee GetToken(tbEmployee res)
        {
            var SecretStr = conf["SystemParams:PrivateKeyString"];
            var key = Encoding.ASCII.GetBytes(SecretStr);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                           {
                               new Claim(ClaimTypes.Sid, res.Id.ToString()),
                               new Claim(ClaimTypes.Name, $"{res.FullName}"),
                               new Claim(ClaimTypes.NameIdentifier, res.Phone.ToString()),
                               new Claim(ClaimTypes.Role, "employee"),
                           }),
                Expires = DateTime.Now.AddDays(170),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
            return new viEmployee
            {
                Id = res.Id,
                TelegramId = res.TelegramId.Value,
                Token = token
            };
        }

        public async ValueTask<Answer<viEmployee>> LoginEmployeeAsync(viEmployeeAuthorization authorization)
        {
            using var tran = await db.Database.BeginTransactionAsync();
            try
            {
                var hash = CHash.EncryptMD5(authorization.Password);
                var res = await db.tbEmployees.FirstOrDefaultAsync(x => x.Phone == authorization.Phone && x.Password == hash);

                if (res == null)
                {
                    await tran.RollbackAsync();
                    return new Answer<viEmployee>(false, "Неправильный логин или пароль");
                }

                res.TelegramId = authorization.TelegramId;
                res.Language = authorization.Lang;
                await db.SaveChangesAsync();
                await tran.CommitAsync();

            return new Answer<viEmployee>(true, "", GetToken(res));

            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError("EmployeeService.LoginEmployeeAsync error: {0} model: {1}", ex.GetAllMessages(), authorization.ToJson());
                return new Answer<viEmployee>(false, "Ошибка авторизации");
            }
        }

        public async ValueTask<Answer<bool>> IsEmployeeRegistered(long telegramId)
        {
            try
            {
                var e = await db.tbEmployees
                    .AsNoTracking()
                    .AnyAsync(x => x.TelegramId == telegramId);

                return new Answer<bool>(true, "", e);
            }
            catch (Exception ex)
            {
                logger.LogError("EmployeeService.IsEmployeeRegistered error: {0}", ex.GetAllMessages());
                return new Answer<bool>(false, "Ошибка авторизации");
            }
        }

        public async ValueTask<AnswerBasic> UpdateEmployeeLanguage(SetProperty<long, string> property)
        {
            using var tran = await db.Database.BeginTransactionAsync();
            try
            {
                var emp = await db.tbEmployees.FindAsync(property.Id);

                if (emp is null)
                {
                    await tran.RollbackAsync();
                    return new AnswerBasic(false, "Ошибка при изменении языка");
                }
                
                emp.Language = property.Value;
                emp.UpdateDate = DateTime.Now;
                emp.UpdateUser = 0;

                return new AnswerBasic(true, "");
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError("EmployeeService.UpdateEmployeeLanguage error: {0} model: {1}", ex.GetAllMessages(), property.ToJson());
                return new AnswerBasic(false, "Ошибка авторизации");
            }
        }
    }
}
