using Kashanshop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.Product;

public class ProductPriceConfig:IEntityTypeConfiguration<ProductPrice>
{
    public void Configure(EntityTypeBuilder<ProductPrice> builder)
    {
        builder.Property(x => x.Price).HasPrecision(12, 0);
        builder.HasOne(x => x.Product).WithMany(x => x.ProductPrices)
            .HasForeignKey(x => x.ProductId);
    }
}