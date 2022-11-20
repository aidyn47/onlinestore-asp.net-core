using Microsoft.EntityFrameworkCore;
using OnlineStore.Data;

namespace OnlineStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OnlineStoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<OnlineStoreContext>>()))
            {
                // Look for any movies.
                if (context.Store.Any())
                {
                    return;   // DB has been seeded
                }
                context.Store.AddRange(
                    new Store
                    {
                        Title = "Sumsung TV 2021",
                        Category = "TV",
                        Price = 7.99M
                    },
                    new Store
                    {
                        Title = "Acer 2019",
                        Category = "Laptops",
                        Price = 7.99M
                    },
                    new Store
                    {
                        Title = "HP 2022",
                        Category = "Laptops",
                        Price = 7.99M
                    },
                    new Store
                    {
                        Title = "Nike Jordan",
                        Category = "Sport",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();

            }
        }
    }
}
