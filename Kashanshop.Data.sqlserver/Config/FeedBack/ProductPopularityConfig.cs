using Kashanshop.Domain.Feedback;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.FeedBack;

public class ProductPopularityConfig:IEntityTypeConfiguration<ProductPopularity>
{
    public void Configure(EntityTypeBuilder<ProductPopularity> builder)
    {
        builder.HasOne(x => x.Product).WithMany(x => x.ProductPopularities)
            .HasForeignKey(x => x.ProductId);
    }
}