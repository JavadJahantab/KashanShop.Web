using Kashanshop.Domain.Factor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.Factor;

public class FactorItemConfig:IEntityTypeConfiguration<FactorItem>
{
    public void Configure(EntityTypeBuilder<FactorItem> builder)
    {
        builder.HasOne(x => x.Product).WithMany(x => x.FactorItems)
            .HasForeignKey(x => x.ProductId);
        builder.HasOne(x => x.Factor).WithMany(x => x.FactorItems)
            .HasForeignKey(x => x.FactorId);
        builder.Property<decimal>(x =>x.Price).HasPrecision(12, 0);
        builder.Property<decimal>(x => x.Quantity).HasPrecision(12, 2);

    }
}