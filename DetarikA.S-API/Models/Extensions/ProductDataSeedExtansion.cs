using Bogus.DataSets;
using DetarikA.S_API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DetarikA.S_API.Models.Extensions
{
    public static class ProductDataSeedExtansion
    {
        public static void ProductSeeds(this ModelBuilder modelBuilder)
        {
            List<Product> products = new();

            for (int i = 1; i < 5; i++)
            {
                Product p = new()
                {
                    ID = i,
                    ProductName = new Commerce("tr").ProductName(),
                    UnitPrice = Convert.ToDecimal(new Commerce("tr").Price()),
                    CategoryID = i,
                };
                products.Add(p);
            }
            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}
