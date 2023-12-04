using Bogus.DataSets;
using DetarikA.S_API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DetarikA.S_API.Models.Extensions
{
    public static class CategoryDataSeedExtension
    {
        public static void CategorySeeds(this ModelBuilder modelBuilder)
        {
            List<Category> categories = new();

            for (int i = 1; i < 5; i++)
            {
                Category c = new Category()
                {
                    ID = i,
                    CategoryName = new Commerce("tr").Categories(1)[0],
                    Description = new Lorem("tr").Sentence(10)
                };
                categories.Add(c);
            }
            modelBuilder.Entity<Category>().HasData(categories);
        }
    }
}
