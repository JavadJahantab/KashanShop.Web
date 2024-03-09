
using Kashanshop.Web.Models.news;

namespace Kashanshop.ApplicationService.UserService;

public interface IReceiverAddressService
{
    Task NewReceiverAddress(ReceiverAddressViewModel receiverAddress);
    Task<List<ReceiverAddressViewModel>> GetReceiverAddressList(UserViewModel user);
    Task<List<ReceiverAddressViewModel>> GetAllReceiverAddressList();
    Task<ReceiverAddressViewModel> GetReceiverAddress(UserViewModel user,string title);
    Task EditReceiverAddress(ReceiverAddressViewModel receiverAddress);
    Task DeleteReceiverAddress(int receiverAddressId);
}