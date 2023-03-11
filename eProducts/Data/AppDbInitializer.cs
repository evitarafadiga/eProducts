using eProducts.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace eProducts.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Mesa de Madeira",
                            Description = "Mesa inteiriça de madeira e ferro para jardim.",
                            Image = "https://live.staticflickr.com/3369/3516521756_3cd729c25c_q.jpg",
                            Price = 399.90
                        },
                        new Product()
                        {
                            Name = "Estante de Madeira",
                            Description = "Estante inteiriça de madeira.",
                            Image = "https://live.staticflickr.com/3333/3515748083_38ae7e390d_q.jpg",
                            Price = 699.90
                        },
                        new Product()
                        {
                            Name = "Mesa de Centro de Madeira",
                            Description = "Mesa inteiriça de madeira com tampo de vidro.",
                            Image = "https://live.staticflickr.com/3300/3516646732_09d467e0ff_q.jpg",
                            Price = 299.90
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
