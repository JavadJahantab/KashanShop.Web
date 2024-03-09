using Kashanshop.Web.Models.Feedback;

namespace Kashanshop.ApplicationService;

public interface ICommentReplyService
{
    Task AddCommentReplyAsync(CommentReplyViewModel model);
    Task DeleteCommentReplyAsync(int CommmentReplyId);
    Task<CommentReplyViewModel> GetCommentReply(int CommmentReplyId);
    Task<List<CommentReplyViewModel>> GetAllCommentReply(int CommentId);
}