using BusinessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ECommerceAppContext(serviceProvider.GetRequiredService<DbContextOptions<ECommerceAppContext>>()))
            {
                if (context.Pages.Any())
                {
                    return;
                }

                context.Pages.AddRange(
                    new Page
                    {
                        Name = "Home",
                        Slug = "home",
                        Content = "Home page"
                    },
                    new Page
                    {
                        Name = "About Us",
                        Slug = "about-us",
                        Content = "About us page"
                    },
                    new Page
                    {
                        Name = "Services",
                        Slug = "services",
                        Content = "Services page"
                    },
                    new Page
                    {
                        Name = "Contact",
                        Slug = "contact",
                        Content = "Contact page"
                    });

                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Fruits",
                        Slug = "fruits"
                    },
                    new Category
                    {
                        Name = "Vegetables",
                        Slug = "vegetables"
                    });

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Apple",
                        CategoryId = 1,
                        Description = "Red apples, per apple",
                        Image = "apple.jpg",
                        Price = 0.5M
                    },
                    new Product
                    {
                        Name = "Bananas",
                        CategoryId = 1,
                        Description = "0.5kg bunch of bananas",
                        Image = "bananas.jpg",
                        Price = 1M
                    },
                    new Product
                    {
                        Name = "Grapes",
                        CategoryId = 1,
                        Description = "0.3 kg seedless grapes",
                        Image = "grapes.jpg",
                        Price = 1.2M
                    },
                    new Product
                    {
                        Name = "Appricots",
                        CategoryId = 1,
                        Description = "1kg appricots",
                        Image = "appricots.jpg",
                        Price = 4.2M
                    },
                    new Product
                    {
                        Name = "Lettuce",
                        CategoryId = 2,
                        Description = "Fresh lettuce",
                        Image = "lettuce.jpg",
                        Price = 0.5M
                    },  new Product
                    {
                        Name = "Peppers",
                        CategoryId = 2,
                        Description = "2 bell peppers",
                        Image = "peppers.jpg",
                        Price = 0.3M
                    },  new Product
                    {
                        Name = "Spring onions",
                        CategoryId = 2,
                        Description = "1 bunch spring onions",
                        Image = "spring-onions.jpg",
                        Price = 1.0M
                    },  new Product
                    {
                        Name = "Tomatoes",
                        CategoryId = 2,
                        Description = "2kg tomatoes",
                        Image = "tomatoes.jpg",
                        Price = 2.5M
                    });

                context.SaveChanges();

            }
        }
    }
}
