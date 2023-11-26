using AsbtCore.UtilsV2;
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
using System.Linq;
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

        private string GetToken(tbEmployee res)
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
                Expires = DateTime.Now.AddDays(365),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public async ValueTask<Answer<string>> LoginEmployeeAsync(viEmployeeAuthorization authorization)
        {
            var hash = CHash.EncryptMD5(authorization.Password);
            var res = await db.tbEmployees
                              .AsNoTracking()
                              .Where(x => x.Phone == authorization.Phone && x.Password == hash)
                              .FirstOrDefaultAsync();

            if (res == null)
            {
                logger.LogError($"Пользователь не найден {authorization}");
                return new Answer<string>(false, "Неправильный логин или пароль");
            }

            return new Answer<string>(true, "", GetToken(res));
        }
    }
}
