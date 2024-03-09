using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.User;

public class OtpCodeConfig:IEntityTypeConfiguration<OtpCode>
{
    public void Configure(EntityTypeBuilder<OtpCode> builder)
    {
        builder.HasOne(x => x.User)
            .WithMany(x => x.OtpCodes).HasForeignKey(x => x.UserId);
    }
}