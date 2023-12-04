using DetarikA.S_API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DetarikA.S_API.Configurations
{
    public class OrderConfiguration : BaseConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.TotalPrice).HasColumnType("money");
            builder.HasMany(x => x.OrderDetails).WithOne(x => x.Order).HasForeignKey(x=> x.OrderID).IsRequired();
        }
    }
}
