using DetarikA.S_API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DetarikA.S_API.Configurations
{
    public class OrderDetailConfiguration : BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            //builder.Property(x => x.UnitPrice).HasColumnType("money");
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.OrderID, x.ProductID });
        }
    }
}
