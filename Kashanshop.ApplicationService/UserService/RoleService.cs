using Kashanshop.Data.sqlserver;
using Kashanshop.Domain.User;
using Kashanshop.Web.Models.news;
using Microsoft.EntityFrameworkCore;

namespace Kashanshop.ApplicationService.UserService;

public class RoleService:IRoleService
{
    private ApplicationDbContext  _context;

    public RoleService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<RoleViewModel>> GetRolesAsync(int userId)
    {
        var roles =await _context
            .UserRoles
            .Include(x => x.Role)
            .Where(x => x.UserId == userId)
            .Select(x => x.Role)
            .ToListAsync();
        var roleViewModelList =new List<RoleViewModel>();
        foreach (var r in roles)
        {
            roleViewModelList.Add(new RoleViewModel()
            {
                Name = r.Name
            });
        }
        return roleViewModelList;
    }

    public async Task SetNewRoleAsync(UserRoleViewModel model)
    {
        UserRole userRole = new UserRole()
        {
            RoleId = model.RoleId,
            UserId = model.UserId
        };
        await _context.UserRoles.AddAsync(userRole);
    }

    public async Task NewRoleAsync(RoleViewModel model)
    {
        Role role = new Role()
        {
            Name = model.Name
        };
        await _context.Roles.AddAsync(role);
    }

    public async Task<List<RoleViewModel>> GetAllRoleAsync()
    {
        List<Role> roles = await _context.Roles.OrderByDescending(p => p.Id).ToListAsync();
        List<RoleViewModel> rolesModel = new List<RoleViewModel>();
        foreach (var r in roles)
        {
            rolesModel.Add(new RoleViewModel()
            {
                Name = r.Name,
                Id = r.Id
            });
        }
        return rolesModel;
    }

    public  async Task EditRoleAsync(RoleViewModel model)
    {
        var role=await _context.Roles.FirstOrDefaultAsync(x => x.Id == model.Id);
        if (role != null)
        {
            role.Name = model.Name;
        }

    }

    public async Task DeleteRoleAsync(int roleId)
    {
        var role = await _context.Roles.FirstOrDefaultAsync(x => x.Id == roleId);
        if (role != null)
        {
            _context.Roles.Remove(role);
        }

    }

    public async Task DeleteUserRoleAsync(int roleId, int userId)
    {
        var userRole = await _context.UserRoles.FirstOrDefaultAsync(x => x.Id == userId && x.Id == roleId);
        if (userRole != null)
        {
            _context.UserRoles.Remove(userRole);
        }
        
    }
}