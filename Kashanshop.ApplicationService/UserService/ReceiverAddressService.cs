using Kashanshop.Data.sqlserver;
using Kashanshop.Domain.User;
using Kashanshop.Web.Models.news;
using Microsoft.EntityFrameworkCore;

namespace Kashanshop.ApplicationService.UserService;

public class ReceiverAddressService:IReceiverAddressService
{
    private ApplicationDbContext _context;

    public ReceiverAddressService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task NewReceiverAddress(ReceiverAddressViewModel model)
    {
        ReceiverAddress receiverAddress = new ReceiverAddress()
        {
            Address = model.Address,
            City = model.City,
            Name = model.Name,
            State = model.State,
            UserId = model.UserId,
            LastName = model.LastName,
            PhoneNumber = model.PhoneNumber,
            PostalCode = model.PostalCode,
            Titel = model.Titel
        };
        await _context.ReceiverAddresses.AddAsync(receiverAddress);
    }

    public async Task<List<ReceiverAddressViewModel>> GetReceiverAddressList(UserViewModel user)
    {
        List<ReceiverAddress> receiverAddresses = 
           await _context.ReceiverAddresses.Where(x => x.UserId == user.Id).ToListAsync();
        List<ReceiverAddressViewModel> model = new List<ReceiverAddressViewModel>();
        foreach (var r in receiverAddresses)
        {
            model.Add((new ReceiverAddressViewModel()
            {
                Address = r.Address,
                City = r.City,
                Name = r.Name,
                LastName = r.LastName,
                State = r.State,
                Titel = r.Titel,
                PhoneNumber = r.PhoneNumber,
                PostalCode = r.PostalCode,
                UserId = r.UserId
            }));
        }
        return model;
    }

    public async Task<List<ReceiverAddressViewModel>> GetAllReceiverAddressList()
    {
        List<ReceiverAddress> receiverAddresses = 
            await _context.ReceiverAddresses.ToListAsync();
        List<ReceiverAddressViewModel> model = new List<ReceiverAddressViewModel>();
        foreach (var r in receiverAddresses)
        {
            model.Add((new ReceiverAddressViewModel()
            {
                Address = r.Address,
                City = r.City,
                Name = r.Name,
                LastName = r.LastName,
                State = r.State,
                Titel = r.Titel,
                PhoneNumber = r.PhoneNumber,
                PostalCode = r.PostalCode,
                UserId = r.UserId
            }));
        }
        return model;
    }

    public async Task<ReceiverAddressViewModel> GetReceiverAddress(UserViewModel user, string title)
    {
        ReceiverAddress receiverAddresses =
            await _context.ReceiverAddresses.FirstOrDefaultAsync(x => x.UserId == user.Id && x.Titel ==title );
        ReceiverAddressViewModel model = new ReceiverAddressViewModel()
        {
            Address = receiverAddresses.Address,
            City = receiverAddresses.City,
            Name = receiverAddresses.Name,
            State = receiverAddresses.State,
            Titel = receiverAddresses.Titel,
            Id = receiverAddresses.Id,
            LastName = receiverAddresses.LastName,
            PhoneNumber = receiverAddresses.PhoneNumber,
            PostalCode = receiverAddresses.PostalCode,
            UserId = receiverAddresses.UserId
        };
        return model;
    }

    public async Task EditReceiverAddress(ReceiverAddressViewModel model)
    {
        ReceiverAddress? receiverAddress = await _context.ReceiverAddresses.FirstOrDefaultAsync(x => x.Id == model.Id);
        if (receiverAddress != null)
        {
            receiverAddress.Address = model.Address;
            receiverAddress.City = model.City;
            receiverAddress.Name = model.Name;
            receiverAddress.State = model.State;
            receiverAddress.UserId = model.UserId;
            receiverAddress.LastName = model.LastName;
            receiverAddress.PhoneNumber = model.PhoneNumber;
            receiverAddress.PostalCode = model.PostalCode;
            receiverAddress.Titel = model.Titel;
        }
    }

    public async Task DeleteReceiverAddress(int receiverAddressId)
    {
        var receiverAddress =await _context.ReceiverAddresses.FirstOrDefaultAsync(x => x.Id == receiverAddressId);
        if (receiverAddress != null)
        {
            _context.ReceiverAddresses.Remove(receiverAddress);
        }
    }
}