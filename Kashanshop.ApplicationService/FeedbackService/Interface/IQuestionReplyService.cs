using Kashanshop.Web.Models.Feedback;

namespace Kashanshop.ApplicationService;

public interface IQuestionReplyService
{
    Task AddQuestionReplyAsync(QuestionReplyViewModel model);
    Task DeleteQuestionReplyAsync(int QuestionReplyId);
    Task<QuestionReplyViewModel> GetQuestionReply(int QuestionReplyId);
    Task<List<QuestionReplyViewModel>> GetAllQuestionReply(int QuestionReplyId);
}