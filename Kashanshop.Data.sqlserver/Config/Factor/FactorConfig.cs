using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.Factor;

public class FactorConfig:IEntityTypeConfiguration<Domain.Factor.Factor>
{
    public void Configure(EntityTypeBuilder<Domain.Factor.Factor> builder)
    {
        builder.Property<decimal>(x =>x.Total).HasPrecision(12, 0);
        builder.Property<decimal>(x => x.Discount).HasPrecision(12, 0);
        builder.Property<decimal>(x => x.PricePaid).HasPrecision(12, 0);
        builder.HasOne(x => x.User)
            .WithMany(x => x.Factors).HasForeignKey(x => x.UserId);
        builder.HasOne(x => x.User)
            .WithMany(x => x.Factors).HasForeignKey(x => x.UserId);
        builder.HasIndex(x => x.Code).IsUnique();
    }
}