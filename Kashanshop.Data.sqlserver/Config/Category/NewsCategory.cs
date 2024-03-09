

using Kashanshop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.Category;

public class NewsCategoryConfig:IEntityTypeConfiguration<Domain.NewsCategory>
{
    public void Configure(EntityTypeBuilder<NewsCategory> builder)
    {
        
    }
}
