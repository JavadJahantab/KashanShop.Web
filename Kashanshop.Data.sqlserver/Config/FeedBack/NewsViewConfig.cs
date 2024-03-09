using Kashanshop.Domain.Feedback;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.FeedBack;

public class NewsViewConfig:IEntityTypeConfiguration<NewsView>
{
    public void Configure(EntityTypeBuilder<NewsView> builder)
    {
        builder.HasOne(x => x.User)
            .WithMany(x => x.NewsViews).HasForeignKey(x => x.UserId);
    }
}