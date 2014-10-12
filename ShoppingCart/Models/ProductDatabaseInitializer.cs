using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Computers"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Smartphones"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Tablets"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Macbook Air 13-inch",
                    Description = "All the power you want. All day long.", 
                    ImagePath="Computers/macbook_air.jpg",
                    UnitPrice = 1099.00,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Dell Latitude 15",
                    Description = "Built to meet the demands of today's businesses - take anywhere performance and business class reliability",
                    ImagePath="Computers/dell.jpg",
                    UnitPrice = 949.99,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Lenovo Thinkpad X240",
                    Description = "Reliability is legendary and it starts with military-spec testing against extremes"
                    + " —  X240 is more than endure the rigors of everyday life",
                    ImagePath="Computers/lenovo_thinkpad.jpg",
                    UnitPrice = 1495.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Toshiba Kirabook 13",
                    Description = "Ultraportable for business needs",
                    ImagePath="Computers/toshiba.jpg",
                    UnitPrice = 1699.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Apple iPhone 6",
                    Description = "iPhone 6 isn’t simply bigger — it’s better in every way. " +
                    "Larger, yet dramatically thinner. More powerful, but remarkably power efficient. " +
                    "With a smooth metal surface that seamlessly meets the new Retina HD display. " +
                    "It’s one continuous form where hardware and software function in perfect unison, creating a new generation of iPhone that’s better by any measure.",
                    ImagePath="Smartphones/iphone6.jpg",
                    UnitPrice = 749.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Google Nexus 5",
                    Description = "Nexus 5 helps you capture the everyday and the epic in fresh new ways. It's the slimmest and fastest Nexus phone ever made, powered by Android™ 4.4, KitKat®.",
                    ImagePath="Smartphones/google_nexus_5.jpg",
                    UnitPrice = 349.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "HTC One M8",
                    Description = "Elegant style, raw power, and sophisticated features",
                    ImagePath="Smartphones/htc_one.jpg",
                    UnitPrice = 329.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Nokia Lumia 1520",
                    Description = "Your creative canvas. Powered by Windows Phone 8.1®.",
                    ImagePath="Smartphones/nokia_lumia_1520.jpg",
                    UnitPrice = 559.56,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Dell Venue 11 Pro",
                    Description = "Enjoy the efficiency and performance of a laptop with the Dell Venue 11 Pro tablet with a 10.8\" Full HD display.",
                    ImagePath="Tablets/dell.jpg",
                    UnitPrice = 499.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Google Nexus 7 (2013)",
                    Description = "Now thinner, lighter, and faster - Nexus 7 brings you the perfect mix of power and portability and features the world's sharpest 7\" tablet screen ",
                    ImagePath="Tablets/nexus7.jpg",
                    UnitPrice = 269.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Apple iPad Air",
                    Description = "The power of lightness.",
                    ImagePath="Tablets/ipad_air.jpg",
                    UnitPrice = 499.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Amazon Kindle Fire HDX 8.9\"",
                    Description = "Go beyond HD.",
                    ImagePath="Tablets/amazon_hdx_89.jpg",
                    UnitPrice = 379.00,
                    CategoryID = 3
                }
            };

            return products;
        }
    }
}