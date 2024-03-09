using Kashanshop.Domain.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kashanshop.Data.sqlserver.Config.User;

public class ReceiverAddressConfig:IEntityTypeConfiguration<ReceiverAddress>
{
    public void Configure(EntityTypeBuilder<ReceiverAddress> builder)
    {
        builder.HasOne(x => x.User)
            .WithMany(x => x.ReceiverAddresses).HasForeignKey(x => x.UserId);
      
        builder.Property(x => x.Address).HasMaxLength(int.MaxValue);
    }
}