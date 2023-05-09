using ShoppingApp.Models;

namespace ShoppingApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using( var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                // Ensure that the database is created and exists
                context.Database.EnsureCreated();

                //Category
                if(!context.Categories.Any()) 
                {
                    context.Categories.AddRange(new List<Category>()
                    {
                        new Category()
                        {
                            CategoryName = "Table"
                        },
                        new Category()
                        {
                            CategoryName = "Chair"
                        },
                        new Category()
                        {
                            CategoryName = "Sofa set"
                        },
                        new Category(){CategoryName = "Bed"}
                    }
                    );
                    context.SaveChanges();
                }
                //Products
                if(!context.Productss.Any()) 
                {
                    context.Productss.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            
                            ProductName = "Garden Chair",
                            ProductImageURL ="https://www.for-sale.co.uk/sh-img/charles-bentley-double-rattan-swing-chair-5047cbab7fc24d0362c7b57919f0e3aa_original_garden%2Bswing%2Bchair.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        },
                        new Product()
                        {   
                            ProductName = "Wooden coffee table",
                            ProductImageURL ="http://2.bp.blogspot.com/-rnz1Lgulcn8/UoV9tAzS6kI/AAAAAAAAVZ0/rlyQgEE0PGY/s1600/claro+walnut+coffee+table+for+sdale+low+angle.jpg",
                            Description ="Brown in color, wooden coffee table",
                            Price = 1200,
                            StockStatus = 1,
                            CategoryId = 1

                        },
                        new Product()
                        {
                            ProductName = "Black leather sofa set",
                            ProductImageURL ="https://www.primeclassicdesign.com/images/leather-living-room-sets/black-italian-sofa-set-loveseat-and-chair-luxury-bh-julie.jpg",
                            Description ="Black Italian sofa set. Leather",
                            Price = 1200,
                            StockStatus = 1,
                            CategoryId = 3,

                        }
                    });
                    context.SaveChanges();
                }
                //Chair
                if (!context.Chairs.Any())
                {
                    context.Chairs.AddRange(new List<Chair>()
                    {
                        new Chair()
                        {

                            ChairName = "Garden Chair",
                            ChairImageURL ="https://www.for-sale.co.uk/sh-img/charles-bentley-double-rattan-swing-chair-5047cbab7fc24d0362c7b57919f0e3aa_original_garden%2Bswing%2Bchair.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        },
                        new Chair()
                        {

                            ChairName = "Garden Chair small",
                            ChairImageURL ="https://www.for-sale.co.uk/sh-img/charles-bentley-double-rattan-swing-chair-5047cbab7fc24d0362c7b57919f0e3aa_original_garden%2Bswing%2Bchair.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        },
                        new Chair()
                        {

                            ChairName = "Garden round Chair",
                            ChairImageURL ="https://www.for-sale.co.uk/sh-img/charles-bentley-double-rattan-swing-chair-5047cbab7fc24d0362c7b57919f0e3aa_original_garden%2Bswing%2Bchair.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        }
                    });
                    context.SaveChanges();
                }
                // Table
                if (!context.Tables.Any())
                {
                    context.Tables.AddRange(new List<Table>()
                    {
                        new Table()
                        {

                            TableName = "Coffee Table",
                            ImageURL ="http://2.bp.blogspot.com/-rnz1Lgulcn8/UoV9tAzS6kI/AAAAAAAAVZ0/rlyQgEE0PGY/s1600/claro+walnut+coffee+table+for+sdale+low+angle.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        },
                        new Table()
                        {

                            TableName = "Coffee Table",
                            ImageURL ="http://2.bp.blogspot.com/-rnz1Lgulcn8/UoV9tAzS6kI/AAAAAAAAVZ0/rlyQgEE0PGY/s1600/claro+walnut+coffee+table+for+sdale+low+angle.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        },
                        new Table()
                        {

                            TableName = "Coffee Table",
                            ImageURL ="http://2.bp.blogspot.com/-rnz1Lgulcn8/UoV9tAzS6kI/AAAAAAAAVZ0/rlyQgEE0PGY/s1600/claro+walnut+coffee+table+for+sdale+low+angle.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        }
                    });
                    context.SaveChanges();
                }
                // Bed
                if (!context.Beds.Any())
                {
                    context.Beds.AddRange(new List<Bed>()
                    {
                        new Bed()
                        {

                            BedName = "King Bed",
                            ImageURL ="http://2.bp.blogspot.com/-rnz1Lgulcn8/UoV9tAzS6kI/AAAAAAAAVZ0/rlyQgEE0PGY/s1600/claro+walnut+coffee+table+for+sdale+low+angle.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        },
                        new Bed()
                        {

                            BedName = "King Bed",
                            ImageURL ="http://2.bp.blogspot.com/-rnz1Lgulcn8/UoV9tAzS6kI/AAAAAAAAVZ0/rlyQgEE0PGY/s1600/claro+walnut+coffee+table+for+sdale+low+angle.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        },
                        new Bed()
                        {

                            BedName = "King Bed",
                            ImageURL ="http://2.bp.blogspot.com/-rnz1Lgulcn8/UoV9tAzS6kI/AAAAAAAAVZ0/rlyQgEE0PGY/s1600/claro+walnut+coffee+table+for+sdale+low+angle.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        }
                    });
                    context.SaveChanges();
                }
                // sofa
                if (!context.Sofasets.Any())
                {
                    context.Sofasets.AddRange(new List<SofaSet>()
                    {
                        new SofaSet()
                        {

                            SofaName = "Leather Sofaset",
                            ImageURL ="https://www.primeclassicdesign.com/images/leather-living-room-sets/black-italian-sofa-set-loveseat-and-chair-luxury-bh-julie.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        },
                       new SofaSet()
                        {

                            SofaName = "Leather Sofaset",
                            ImageURL ="https://www.primeclassicdesign.com/images/leather-living-room-sets/black-italian-sofa-set-loveseat-and-chair-luxury-bh-julie.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        },
                        new SofaSet()
                        {

                            SofaName = "Leather Sofaset",
                            ImageURL ="https://www.primeclassicdesign.com/images/leather-living-room-sets/black-italian-sofa-set-loveseat-and-chair-luxury-bh-julie.jpg",
                            Description ="Garden Swing Chair",
                            Price = 2500,
                            StockStatus = 1,
                            CategoryId = 2

                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
