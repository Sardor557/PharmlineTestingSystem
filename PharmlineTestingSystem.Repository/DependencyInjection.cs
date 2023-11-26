using Microsoft.Extensions.DependencyInjection;
using PharmlineTestingSystem.Repository.Services;
using PharmlineTestingSystem.Shared.Interfaces;

namespace PharmlineTestingSystem.Repository
{
    public static class DependencyInjection
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddScoped<IAnswerService, AnswerService>();
            services.AddScoped<IDicoService, DicoService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
        }
    }
}
