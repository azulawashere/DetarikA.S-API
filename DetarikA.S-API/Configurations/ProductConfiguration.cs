using DetarikA.S_API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DetarikA.S_API.Configurations
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.UnitPrice).HasColumnType("money");
            builder.HasMany(x=> x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x=> x.ProductID).IsRequired();
        }
    }
}
