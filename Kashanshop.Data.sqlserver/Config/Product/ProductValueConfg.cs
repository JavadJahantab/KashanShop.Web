using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.Product;

public class ProductValueConfg:IEntityTypeConfiguration<Domain.Product>
{
    public void Configure(EntityTypeBuilder<Domain.Product> builder)
    {

    }
}