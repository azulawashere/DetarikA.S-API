using DetarikA.S_API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DetarikA.S_API.Models.Extensions
{
    public static class DealerDataSeedExtension
    {
        public static void DealerSeeds(this ModelBuilder modelBuilder)
        {
            Dealer d = new Dealer()
            {
                ID =1,
                CompanyName = "AlfaTeam",
                ShippingAdress = "Istanbul Tahtakale Merkezzz",
            };
            modelBuilder.Entity<Dealer>().HasData(d);
        }
    }
}
