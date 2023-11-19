using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Shared.Interfaces
{
    public interface IUserService
    {
        Task<Answer<viUser>> CreateUserAsync(viUserRegister value);
        Task<Answer<viUser>> AuthenticateAsync(viAuthenticateModel model, string ip);
        Task<AnswerBasic> UpdateAsync(viUser user);
        Task<AnswerBasic> ChangePasswordAsync(SetProperty<int, string> p);
        Task<Answer<tbUser>> GetByIdAsync(int id);
        Task<Answer<tbUser[]>> GetAllUsersAsync();
        Task<Answer<viUser>> SetUserStatusAsync(SetProperty<int, int> model);
    }
}
