using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.FeedBack;

public class ProductCommentConfig:IEntityTypeConfiguration<Domain.Feedback.ProductComment>
{
    public void Configure(EntityTypeBuilder<Domain.Feedback.ProductComment> builder)
    {
        builder.HasOne(x => x.Product).WithMany(x => x.ProductComments)
                        .HasForeignKey(x => x.ProductId);

    }
}