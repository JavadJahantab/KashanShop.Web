using Kashanshop.Domain.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.User;

public class UserRoleConfig:IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasOne(x => x.User)
            .WithMany(x => x.UserRoles).HasForeignKey(x => x.UserId);
    }
}