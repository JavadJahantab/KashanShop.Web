using System.Security.Cryptography;
using System.Text;
using Kashanshop.Data.sqlserver;
using Kashanshop.Domain.User;
using Kashanshop.Web.Models.news;
using Microsoft.EntityFrameworkCore;
using Mapster;

namespace Kashanshop.ApplicationService.UserService;

public class UserService:IUserService
{
    private DbSet<User> _users;
    private ApplicationDbContext  _context;

    public UserService( ApplicationDbContext  context)
    {
        _users = context.Users;
        _context = context;
    }

    public async Task NewUserAsync(UserViewModel model)
    {
        var user = new User()
        {
            Password = Make_Password_Hash(model.Password),
            Name = model.Name,
            Username = model.PhoneNumber.ToString(),
            PhoneNumber = model.PhoneNumber,
            NationalCode = model.NationalCode,
        };
        await _users.AddAsync(user);
    }

    private IQueryable<User> GetQuery(string search)
    {
        var query = _context.Users.AsQueryable().AsNoTracking();
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.Name.Contains(search));
        }
        return query;
    }

    public async Task<List<UserViewModel>> UserListAsync(int skip, int take, string search)
    {
        var query = GetQuery(search);
        List<UserViewModel> userViewModels = new List<UserViewModel>();
        var users = await query.OrderByDescending(p => p.Id).Skip(skip).Take(take).ToListAsync();
        userViewModels = users.Adapt<List<UserViewModel>>();
        /*
        foreach (var u in users)
        {
            userViewModels.Add(new UserViewModel()
            {
                Name = u.Name,
                Username = u.PhoneNumber.ToString(),
                PhoneNumber = u.PhoneNumber,
                NationalCode = u.NationalCode,
                Password = Make_Password_Hash(u.Password)
            });
        }
        */
        return userViewModels;
    }

    public string Make_Password_Hash( string password)
    {
        if (String.IsNullOrEmpty(password))
            return password;
        using SHA512Managed sha512 = new SHA512Managed();
        var bytes = sha512.ComputeHash(Encoding.ASCII.GetBytes(password));
        return  String.Join("",bytes);
    }
    

    public async Task<UserViewModel> FindUserAsync(string username)
    {
        var user= _users.FirstOrDefaultAsync(x => x.Username == username);
        var viewModel=user.Adapt<UserViewModel>();
        /*
        var viewModel = new UserViewModel()
        {
            Image = user.Image,
            Name = user.Name,
            ActivationStatus = user.ActivationStatus,
            Username = user.Username,
            LastName = user.LastName,
            NationalCode = user.NationalCode,
            PhoneNumber = user.PhoneNumber
        };
        */
        return viewModel;
    }

    public async Task<bool> FindUserAsync(LoginUserViewModel model)
    {
        return await _users.AnyAsync(x => x.Username == model.Username && x.Password==Make_Password_Hash(model.Password) );
    }

    public async Task EditUserAsync(UserViewModel model)
    {
        var user=await _users.FirstOrDefaultAsync(x => x.Username == model.Username);
        if ( user != null){
                user.Password = Make_Password_Hash(model.Password);
                user.Name = model.Name;
                user.Username = model.PhoneNumber.ToString();
                user.PhoneNumber = model.PhoneNumber;
                user.NationalCode = model.NationalCode;
        }
    }

    public async Task DeleteUserAsync(int userId)
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
        if (user != null)
        {
            _context.Users.Remove(user);
        }
    }
}