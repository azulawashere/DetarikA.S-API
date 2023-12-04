using DetarikA.S_API.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DetarikA.S_API.Configurations
{
    public class DealerConfiguration : BaseConfiguration<Dealer>
    {
        public override void Configure(EntityTypeBuilder<Dealer> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Orders).WithOne(x => x.Dealer).HasForeignKey(x => x.DealarID).IsRequired();
        }
    }
}
