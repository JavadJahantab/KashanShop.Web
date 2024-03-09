using System.Buffers;
using Kashanshop.Data.sqlserver;
using Kashanshop.Web.Models.news;
using Microsoft.EntityFrameworkCore;

namespace Kashanshop.ApplicationService.UserService;

public class MessageService:IMessageService
{
    private ApplicationDbContext _context;

    public MessageService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task NewMessageAsync(MessageViewModel model)
    {
        Message message = new Message()
        {
            Status = MessageStatus.Send,
            Titel = model.Titel,
            UserId = model.UserId,
            Text = model.Value,
            CreationDate = model.CreationDate

        };
        await _context.Messages.AddAsync(message);
    }

    public async Task<List<MessageViewModel>> GetMessagesAsync(int userId)
    {
        List<Message> messages=await _context.Messages.ToListAsync();
        List<MessageViewModel> list = new List<MessageViewModel>();
        foreach (var m in messages)
        {
            list.Add(new MessageViewModel()
            {
                Status = m.Status,
                Id = m.Id,
                Titel = m.Titel,
                Value = m.Text,
                CreationDate = m.CreationDate,
                UserId = m.UserId
            });
        }
        return list;
    }

    public async Task<List<MessageViewModel>> GetAllMessagesAsync()
    {
        List<Message> messages=await _context.Messages.ToListAsync();
        List<MessageViewModel> list = new List<MessageViewModel>();
        foreach (var m in messages)
        {
            list.Add(new MessageViewModel()
            {
                Status = m.Status,
                Id = m.Id,
                Titel = m.Titel,
                Value = m.Text,
                CreationDate = m.CreationDate,
                UserId = m.UserId
            });
        }
        return list;
    }

    public async Task DeleteMessageAsync(int messageId)
    {
        var message = await _context.Messages.FirstOrDefaultAsync(x => x.Id == messageId);
        if(message != null){
            _context.Messages.Remove(message);
        }
        
    }
}