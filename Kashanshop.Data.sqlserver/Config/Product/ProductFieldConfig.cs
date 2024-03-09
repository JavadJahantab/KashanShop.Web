using Kashanshop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.Product;

public class ProductFieldConfig:IEntityTypeConfiguration<ProductField>
{
    public void Configure(EntityTypeBuilder<ProductField> builder)
    {
        //builder.HasOne(x => x.Product).WithMany(x => x.ProductFields)
        //      .HasForeignKey(x => x.ProductId);
    }
}