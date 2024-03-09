

using Kashanshop.Web.Models.news;

namespace Kashanshop.ApplicationService.UserService;

public interface IMessageService
{
    Task NewMessageAsync(MessageViewModel message);
    Task<List<MessageViewModel>> GetMessagesAsync(int userId);
    Task<List<MessageViewModel>> GetAllMessagesAsync();
    Task DeleteMessageAsync(int messageId);
}