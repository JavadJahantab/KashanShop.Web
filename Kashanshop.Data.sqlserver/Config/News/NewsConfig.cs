using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.News;

public class NewsConfig:IEntityTypeConfiguration<Domain.News.News>
{
    public void Configure(EntityTypeBuilder<Domain.News.News> builder)
    {
        builder.Property(x => x.NewsText).HasMaxLength(int.MaxValue);
        builder.HasOne(x => x.User)
            .WithMany(x => x.NewsList).HasForeignKey(x => x.UserId);
    }
}