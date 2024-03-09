using Kashanshop.Web.Models.Feedback;

namespace Kashanshop.ApplicationService.FeedbackService;

public class CommentReplyService:ICommentReplyService
{
    private ICommentReplyService _commentReplyServiceImplementation;
    public async Task AddCommentReplyAsync(CommentReplyViewModel model)
    {
        await _commentReplyServiceImplementation.AddCommentReplyAsync(model);
    }

    public async Task DeleteCommentReplyAsync(int CommmentReplyId)
    {
        await _commentReplyServiceImplementation.DeleteCommentReplyAsync(CommmentReplyId);
    }

    public async Task<CommentReplyViewModel> GetCommentReply(int CommmentReplyId)
    {
        return await _commentReplyServiceImplementation.GetCommentReply(CommmentReplyId);
    }

    public async Task<List<CommentReplyViewModel>> GetAllCommentReply(int CommentId)
    {
        return await _commentReplyServiceImplementation.GetAllCommentReply(CommentId);
    }
}