

using Kashanshop.Web.Models.news;

namespace Kashanshop.ApplicationService.UserService;

public interface IUserService
{
    Task NewUserAsync(UserViewModel user);
    Task<List<UserViewModel>> UserListAsync(int skip, int take, string search);
    Task<UserViewModel> FindUserAsync(string username);
    Task<bool> FindUserAsync(LoginUserViewModel model);
    Task EditUserAsync(UserViewModel user);
    Task DeleteUserAsync(int userId);
}