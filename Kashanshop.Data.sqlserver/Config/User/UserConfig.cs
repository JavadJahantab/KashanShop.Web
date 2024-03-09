using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.User;

public class UserConfig:IEntityTypeConfiguration<Domain.User.User>
{
    public void Configure(EntityTypeBuilder<Domain.User.User> builder)
    {
       
    }
}