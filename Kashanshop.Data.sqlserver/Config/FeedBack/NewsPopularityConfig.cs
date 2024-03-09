using Kashanshop.Domain.Feedback;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.FeedBack;

public class NewsPopularityConfig:IEntityTypeConfiguration<NewsPopularity>
{
    public void Configure(EntityTypeBuilder<NewsPopularity> builder)
    {
        builder.HasOne(x => x.User)
            .WithMany(x => x.NewsPopularities).HasForeignKey(x => x.UserId);
    }
}