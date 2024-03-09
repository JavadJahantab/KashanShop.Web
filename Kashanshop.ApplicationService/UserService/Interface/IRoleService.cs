
using Kashanshop.Web.Models.news;

namespace Kashanshop.ApplicationService.UserService;

public interface IRoleService
{
    Task<List<RoleViewModel>> GetRolesAsync(int userId);
    Task SetNewRoleAsync(UserRoleViewModel model);
    Task NewRoleAsync(RoleViewModel model);
    Task<List<RoleViewModel>> GetAllRoleAsync();
    Task EditRoleAsync(RoleViewModel model);
    Task DeleteRoleAsync(int roleId);
    Task DeleteUserRoleAsync(int roleId,int userId);

    
}