using WebApplication1.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Data.Repositories;

namespace WebApplication1.Data.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.ProductSorters.Any())
            {
                context.ProductSorters.AddRange(ProductSorters.Select(c => c.Value));
            }
            if (!context.UsersData.Any())
            {
                context.AddRange
                (
                    new User
                    {
                        FirstName = "Bozo",
                        LastName = "Admin",
                        Email = "admin@vsite.hr",
                        Password = "test",
                        IsAdmin = true,
                        IsEmailVerified=true
                    }
                );
            }

            if (!context.Products.Any())
            {
                context.AddRange
                (
                    new Product
                    {
                        Name = "Super Mario Bros.",
                        Price = 50,
                        Description = "Stara igrica i dalje vrlo popularna",
                        ProductSorter = ProductSorters["Platform"],
                        ImageURL = "/Images/supermario.png",
                        InStock = true,
                        IsMostLiked = false
                    },
                    new Product
                    {
                        Name = "Fortnite",
                        Price = 0,
                        Description = "Najstreamnija igra trenutno!",
                        ProductSorter = ProductSorters["Shooting"],
                        ImageURL = "/Images/fortnite.jpg",
                        InStock = true,
                        IsMostLiked = false
                    },
                    new Product
                    {
                        Name = "Call Of Duty",
                        Price = 400,
                        Description = "Igra s puno nastavaka te pricom koja prati svaki dio",
                        ProductSorter = ProductSorters["Shooting"],
                        ImageURL = "/Images/cod.jpg",
                        InStock = true,
                        IsMostLiked = false
                    },
                    new Product
                    {
                        Name = "Donkey Kong",
                        Price = 50,
                        Description = "Old school. Say no more.",
                        ProductSorter = ProductSorters["Platform"],
                        ImageURL = "/Images/donkey.jpg",
                        InStock = true,
                        IsMostLiked = false
                    },
                    new Product
                    {
                        Name = "Tekken",
                        Price = 200,
                        Description = "Fighting igrica, jos jedan klasik prvo izasao za PS",
                        ProductSorter = ProductSorters["Fighting"],
                        ImageURL = "/Images/tekken.jpg",
                        InStock = true,
                        IsMostLiked = true
                    },
                    new Product
                    {
                        Name = "Mortal Kombat",
                        Price = 250,
                        Description = "Stari ili novi? Pitanje je sad",
                        ProductSorter = ProductSorters["Fighting"],
                        ImageURL = "/Images/mortal.jpeg",
                        InStock = true,
                        IsMostLiked = true
                    },
                    new Product
                    {
                        Name = "World Of Warcraft",
                        Price = 15,
                        Description = "Igra koja dominira zadnje desetljece",
                        ProductSorter = ProductSorters["Strategic"],
                        ImageURL = "/Images/wow.jpg",
                        InStock = true,
                        IsMostLiked = false
                    },
                    new Product
                    {
                        Name = "Stronghold",
                        Price = 0,
                        Description = "Cisti primjer strateske igre",
                        ProductSorter = ProductSorters["Strategic"],
                        ImageURL = "/Images/stronghold.jpg",
                        InStock = true,
                        IsMostLiked = false
                    },
                    new Product
                    {
                        Name = "Age Of Empires",
                        Price = 0,
                        Description = "Tko je krenuo sa strategijama, krenuo je s ovom igricom!",
                        ProductSorter = ProductSorters["Strategic"],
                        ImageURL = "/Images/ageofempires.jpg",
                        InStock = true,
                        IsMostLiked = true
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, ProductSorter> productSorters;
        public static Dictionary<string, ProductSorter> ProductSorters
        {
            get
            {
                if (productSorters == null)
                {
                    var productSortersList = new ProductSorter[]
                    {
                        new ProductSorter { Name = "Platform", Description="Skakanje i penjanje!" },
                        new ProductSorter { Name = "Shooting", Description="Pucanje" },
                        new ProductSorter { Name = "Fighting", Description="Udari, izmakni, obrani!" },
                        new ProductSorter { Name = "Strategic", Description="Vodi svoje ljudi u pobjede" }

                    };

                    productSorters = new Dictionary<string, ProductSorter>();

                    foreach (ProductSorter sorter in productSortersList)
                    {
                        productSorters.Add(sorter.Name, sorter);
                    }
                }

                return productSorters;
            }
        }
    }
}

