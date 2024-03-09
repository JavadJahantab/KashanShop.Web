using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.Category;

public class ProductCategoryConfig:IEntityTypeConfiguration<Domain.ProductCategory>
{
    public void Configure(EntityTypeBuilder<Domain.ProductCategory> builder)
    {
        builder.HasOne(x => x.LeaderCategory).WithMany(x => x.SubCategories).HasForeignKey(x => x.LeaderCategoryId);
    }
}