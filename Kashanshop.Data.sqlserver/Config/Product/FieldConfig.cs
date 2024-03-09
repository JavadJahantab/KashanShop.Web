using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.Product;

public class FieldConfig:IEntityTypeConfiguration<Domain.Product>
{
    public void Configure(EntityTypeBuilder<Domain.Product> builder)
    {

    }
}