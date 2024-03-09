using Kashanshop.Data.sqlserver;
using Kashanshop.Domain.User;
using Kashanshop.Web.Models.news;
using Microsoft.EntityFrameworkCore;

namespace Kashanshop.ApplicationService.UserService;

public class OtpCodeService:IOtpCodeService
{
    private ApplicationDbContext _context;

    public OtpCodeService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task NewOtpCodeAsync(OtpCodeViewModel model)
    {
        OtpCode otpCode = new OtpCode()
        {
            IsUsed = false,
            Code = model.Code,
            UserId = model.UserId
        };
        await _context.OtpCodes.AddAsync(otpCode);
    }

    public async Task<bool> CheckOtpCode(string code, UserViewModel user)
    {
        var otpCode = await _context.OtpCodes.FirstOrDefaultAsync(x => x.Code == code && x.UserId == user.Id);
        return !(otpCode==null && otpCode.IsUsed && otpCode.IsValid);
    }

    public async Task UsedOtpCode(int otpCodeId)
    {
        var otpCode =await _context.OtpCodes.FirstOrDefaultAsync(x => x.Id == otpCodeId);
        otpCode.IsUsed = true;
    }
}