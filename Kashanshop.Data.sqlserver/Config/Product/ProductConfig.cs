using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.Product;

public class ProductConfig:IEntityTypeConfiguration<Domain.Product>
{
    public void Configure(EntityTypeBuilder<Domain.Product> builder)
    {
        builder.HasOne(x => x.User).WithMany(x => x.Products)
            .HasForeignKey(x => x.UserId);
        builder.HasOne(x => x.Category).WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId);
        builder.Property(x => x.Description).HasMaxLength(int.MaxValue);
    }
}