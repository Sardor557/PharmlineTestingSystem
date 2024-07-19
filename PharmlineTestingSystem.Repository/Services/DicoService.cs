using AsbtCore.UtilsV2;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PharmlineCRMSystem.Shared.Services;
using PharmlineTestingSystem.Database;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Repository.Services
{
    public sealed class DicoService : IDicoService
    {
        private readonly MyDbContext db;
        private readonly ILogger<DicoService> logger;
        private readonly IHttpContextAccessorExtensions accessor;

        public DicoService(MyDbContext db, IHttpContextAccessorExtensions accessor, ILogger<DicoService> logger)
        {
            this.db = db;
            this.accessor = accessor;
            this.logger = logger;
        }

        public async ValueTask<Answer<spDrug[]>> GetDrugsAsync(int? status = null)
        {
            try
            {
                var query = db.spDrugs
                    .OrderBy (x => x.Name)
                    .AsNoTracking();

                if (status.HasValue)
                    query = query.Where(x => x.Status == status.Value).OrderBy(x => x.Name);

                var drugs = await query.ToArrayAsync();

                return new Answer<spDrug[]>(true, "", drugs);
            }
            catch (Exception ex)
            {
                logger.LogError("DicoService.GetDrugsAsync error: {0}", ex.GetAllMessages());
                return new Answer<spDrug[]>(false, "Ошибка");
            }
        }

        public async ValueTask<Answer<int>> GetDrugIdByNameAsync(string name)
        {
            try
            {
                var drug = await db.spDrugs
                    .AsNoTracking()
                    .Where(x => x.Name == name)
                    .Select(x => x.Id)
                    .FirstOrDefaultAsync();

                if (drug == 0)
                    return new Answer<int>(false, "Такого препарата нет");

                return new Answer<int>(true, "", drug);
            }
            catch (Exception ex)
            {
                logger.LogError("DicoService.GetDrugIdByNameAsync error: {0}", ex.GetAllMessages());
                return new Answer<int>(false, "Ошибка");
            }
        }

        public async ValueTask<AnswerBasic> AddDrugAsync(spDrug drug)
        {
            using var tran = await db.Database.BeginTransactionAsync();
            try
            {
                drug.Validate();

                drug.CreateDate = DateTime.Now;
                drug.CreateUser = accessor.GetId();

                await db.spDrugs.AddAsync(drug);
                await db.SaveChangesAsync();
                await tran.CommitAsync();

                return new AnswerBasic(true, "OK");
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError("DicoService.AddDrugAsync error: {0} model: {1}", ex.GetAllMessages(), drug.ToJson());
                return new AnswerBasic(false, "Ошибка");
            }
        }

        public async ValueTask<AnswerBasic> EditDrugAsync(spDrug drug)
        {
            using var tran = await db.Database.BeginTransactionAsync();
            try
            {
                drug.Validate();
                drug.UpdateDate = DateTime.Now;
                drug.UpdateUser = accessor.GetId();

                db.spDrugs.Update(drug);
                await db.SaveChangesAsync();
                await tran.CommitAsync();

                return new AnswerBasic(true, "");
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError("DicoService.EditDrugAsync error: {0} model: {1}", ex.GetAllMessages(), drug.ToJson());
                return new AnswerBasic(false, "Ошибка");
            }
        }

        public async ValueTask<Answer<spStatus[]>> GetStatusesAsync()
        {
            try
            {
                var statuses = await db.spStatuses
                    .AsNoTracking()
                    .ToArrayAsync();

                return new Answer<spStatus[]>(true, "", statuses);
            }
            catch (Exception ex)
            {
                logger.LogError("DicoService.GetStatusesAsync error: {0}", ex.GetAllMessages());
                return new Answer<spStatus[]>(false, "Ошибка");
            }
        }

        public async ValueTask<Answer<int>> AddEmployeeAsync(tbEmployee employee)
        {
            using var tran = await db.Database.BeginTransactionAsync();
            try
            {
                employee.Validate();
                employee.Phone = "+998" + employee.Phone;
                employee.Password = CHash.EncryptMD5(employee.Password);
                employee.CreateDate = DateTime.Now;
                employee.CreateUser = accessor.GetId();

                await db.tbEmployees.AddAsync(employee);
                await db.SaveChangesAsync();
                await tran.CommitAsync();

                return new Answer<int>(true, "OK", employee.Id);
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError("DicoService.AddEmployeeAsync error: {0} model:{1}", ex.GetAllMessages(), employee.ToJson());
                return new Answer<int>(false, "Ошибка");
            }
        }

        public async ValueTask<AnswerBasic> EditEmployeeAsync(tbEmployee employee)
        {
            using var tran = await db.Database.BeginTransactionAsync();
            try
            {
                employee.Validate();
                employee.Phone = "+998" + employee.Phone;
                employee.Password = CHash.EncryptMD5(employee.Password);
                employee.UpdateDate = DateTime.Now;
                employee.UpdateUser = accessor.GetId();

                db.tbEmployees.Update(employee);
                await db.SaveChangesAsync();
                await tran.CommitAsync();

                return new AnswerBasic(true, "OK");
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError("DicoService.EditEmployeeAsync error: {0} model:{1}", ex.GetAllMessages(), employee.ToJson());
                return new AnswerBasic(false, "Ошибка");
            }
        }

        public async ValueTask<Answer<tbEmployee[]>> GetEmployeesAsync()
        {
            try
            {
                var emps = await db.tbEmployees
                    .AsNoTracking()
                    .OrderBy(x => x.FullName)
                    .ToArrayAsync();

                emps = emps.Select(x => { x.Password = null; return x; }).ToArray();

                return new Answer<tbEmployee[]>(true, "", emps);
            }
            catch (Exception ex)
            {
                logger.LogError("DicoService.GetStatusesAsync error: {0}", ex.GetAllMessages());
                return new Answer<tbEmployee[]>(false, "Ошибка");
            }
        }
    }
}
