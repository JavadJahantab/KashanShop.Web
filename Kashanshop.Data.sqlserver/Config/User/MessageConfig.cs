using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.User;

public class MessageConfig:IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.HasOne(x => x.User)
            .WithMany(x => x.Messages).HasForeignKey(x => x.UserId);
    }
}