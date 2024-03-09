using Kashanshop.Domain.Feedback;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.FeedBack;

public class CommentReplyConfig:IEntityTypeConfiguration<CommentReply>
{
    public void Configure(EntityTypeBuilder<CommentReply> builder)
    {
        builder.HasOne(x => x.ProductComment).WithMany(x => x.CommentReplies)
            .HasForeignKey(x => x.ProductCommentId);
    }
}