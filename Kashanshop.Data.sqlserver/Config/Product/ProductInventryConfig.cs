using Kashanshop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.Product;

public class ProductInventoryConfig:IEntityTypeConfiguration<ProductInventory>
{
    public void Configure(EntityTypeBuilder<ProductInventory> builder)
    {
        builder.HasOne(x => x.Product).WithMany(x => x.ProductInventories)
            .HasForeignKey(x => x.ProductId);
    }
}