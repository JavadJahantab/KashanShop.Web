using Kashanshop.Domain.Feedback;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.FeedBack;

public class QuestionReplyConfig:IEntityTypeConfiguration<QuestionReply>
{
    public void Configure(EntityTypeBuilder<QuestionReply> builder)
    {
        builder.HasOne(x => x.ProductQuestion).WithMany(x => x.QuestionReplies)
            .HasForeignKey(x => x.ProductQuestionId);
    }
}