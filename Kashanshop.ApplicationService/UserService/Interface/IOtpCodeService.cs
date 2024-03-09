

using Kashanshop.Web.Models.news;

namespace Kashanshop.ApplicationService.UserService;

public interface IOtpCodeService
{
    Task NewOtpCodeAsync(OtpCodeViewModel model);
    Task<bool> CheckOtpCode(string code,UserViewModel user);
    Task UsedOtpCode(int otpCodeId);
}