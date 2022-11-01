namespace _92031083_ModelRailStore.Migrations.StoreConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using _92031083_ModelRailStore.Models;

    internal sealed class StoreConfiguration : DbMigrationsConfiguration<_92031083_ModelRailStore.Models.StoreContext>
    {
        public StoreConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "_92031083_ModelRailStore.Models.StoreContext";
        }

        protected override void Seed(_92031083_ModelRailStore.Models.StoreContext context)
        {
            var categories = new List<Category>

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            {
                new Category { Name = "Locomotives"} ,
                new Category { Name = "Carriages"} ,
                new Category { Name = "Track"} ,
                new Category { Name = "Electrical"} ,
                new Category { Name = "Buildings"} ,
                new Category { Name = "Scenery"} ,
                new Category { Name = "Books"} ,
            };

            categories.ForEach(c => context.Categories.AddOrUpdate(prop => prop.Name, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product {Name = "Bachmann Santa Fe", Year="2001", Description="Yellow Red 16V Dcc enabled", Price=
                169.00M, CategoryID= categories.Single(c => c.Name == "Locomotives").ID },

                new Product {Name = "Kato Shinkansen N700a", Year="2020", Description="Silver 16V Dcc enabled", Price=
                249.05M, CategoryID= categories.Single(c => c.Name == "Locomotives").ID },

                new Product {Name = "Lima Diesel Electric locomotive", Year="1977", Description="Blue Yellow DC 12V Dcc ready", Price=
                89.55M, CategoryID= categories.Single(c => c.Name == "Locomotives").ID },

                new Product {Name = "Bachmann Ex Southern", Year="2003", Description="Blue Covered Carriage Truck", Price=
                39.00M, CategoryID= categories.Single(c => c.Name == "Carriages").ID },

                new Product {Name = "Atlas Extended Vision Caboose", Year="2009", Description="Green Yellow Caboose", Price=
                35.95M, CategoryID= categories.Single(c => c.Name == "Carriages").ID },

                new Product {Name = "Kato 4 Carriage", Year="2013", Description="Coach in Orange Green Shonan line livery", Price=
                49.95M, CategoryID= categories.Single(c => c.Name == "Carriages").ID },

                new Product {Name = "Kato 2 150 Track", Year="2020", Description="Grey Unitrack Straight Track 246mm 4 Pack", Price=
                28.95M, CategoryID= categories.Single(c => c.Name == "Track").ID },

                new Product {Name = "Bachmann EZ Track", Year="2020", Description="Nickel Silver Straight Track 1 Piece", Price=
                12.95M, CategoryID= categories.Single(c => c.Name == "Track").ID },

                new Product {Name = "Bachmann Dynamis EZ Command", Year="2018", Description="OO HO Wireless DCC Control System", Price=
                410.20M, CategoryID= categories.Single(c => c.Name == "Electrical").ID },

                new Product {Name = "Kato Controller", Year="2020", Description="N Scale Power Pack Standard SX", Price=
                129.95M, CategoryID= categories.Single(c => c.Name == "Electrical").ID },

                new Product {Name = "Miniature Railway Building", Year="2019", Description="Wood style Country Train Station Building", Price=
                15.62M, CategoryID= categories.Single(c => c.Name == "Buildings").ID },

                new Product {Name = "Railway Tall Building", Year="2015", Description="Outland Models Office Building", Price=
                18.09M, CategoryID= categories.Single(c => c.Name == "Buildings").ID },

                new Product {Name = "Railway Scenery Model Tree", Year="2018", Description="120 lot Landscape Decorative Props", Price=
                26.00M, CategoryID= categories.Single(c => c.Name == "Scenery").ID },

                new Product {Name = "Railway Scenery Coconut Tree", Year="2019", Description="2pcs Coconut Tree Park Layout Scenery", Price=
                26.00M, CategoryID= categories.Single(c => c.Name == "Scenery").ID },

                new Product {Name = "Australian Model Railway Magazine", Year="2019", Description="by Dunn Ian Pictorial Soft Cover", Price=
                20.00M, CategoryID= categories.Single(c => c.Name == "Books").ID },

                new Product {Name = "Railway Layout Construction", Year="2020", Description="by Nigel Burkin Ideas for layouts and construction", Price=
                41.99M, CategoryID= categories.Single(c => c.Name == "Books").ID },
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order {
                    DeliveryAddress = new Address {
                        AddressLine1="20 Maxine Street",
                        AddressLine2="Red Light District",
                        Town="Palmerston North",
                        Country="New Zealand",
                        PostCode="7511" },
                    TotalPrice=89.75M,
                    UserID="user1@yahoo.com",
                    DateCreated=new DateTime(2021, 1, 1),
                    DeliveryName="Mike" },

                new Order {
                    DeliveryAddress = new Address {
                        AddressLine1="19 Te Aro Lane",
                        Town="Manchester",
                        Country="United Kingdom",
                        PostCode="M155NZ" },
                    TotalPrice=2075.01M,
                    UserID="user2@hotmail.com",
                    DateCreated=new DateTime(2020, 10, 10),
                    DeliveryName="Henry" },

                new Order {
                    DeliveryAddress = new Address {
                        AddressLine1="1 Hotpepper Boulevarde",
                        AddressLine2="Arrondissement no 7",
                        Town="Paris",
                        Country="France",
                        PostCode="FR0025" },
                    TotalPrice=890.69M,
                    UserID="user3@outlook.com",
                    DateCreated=new DateTime(2020, 5, 10),
                    DeliveryName="Francis" },

                new Order {
                    DeliveryAddress = new Address {
                        AddressLine1="17 Westchester Condos",
                        AddressLine2="Venice Beach",
                        Town="Miami",
                        Country="USA",
                        PostCode="90217" },
                    TotalPrice=1019.75M,
                    UserID="user4@email.com",
                    DateCreated=new DateTime(2020, 12, 12),
                    DeliveryName="Christine" },

                new Order {
                    DeliveryAddress = new Address {
                        AddressLine1="49 Manners Street",
                        AddressLine2="Te Aro",
                        Town="Wellington",
                        Country="New Zealand",
                        PostCode="6088" },
                    TotalPrice=20.05M,
                    UserID="user5@this.net",
                    DateCreated=new DateTime(2021, 1, 1),
                    DeliveryName="Peter" }
                };

            orders.ForEach(c => context.Orders.AddOrUpdate(o => o.DateCreated, c));
            context.SaveChanges();

            var orderLines = new List<OrderLine>
            {
                new OrderLine {
                    OrderID = 1,
                    ProductID = products.Single( c=> c.Name == "Kato Controller").ID,
                    ProductName="Kato Controller",
                    Quantity=1,
                    UnitPrice=products.Single( c=> c.Name == "Kato Controller").Price
                },

                new OrderLine {
                    OrderID = 2,
                    ProductID = products.Single( c=> c.Name == "Atlas Extended Vision Caboose").ID,
                    ProductName="Atlas Extended Vision Caboose",
                    Quantity=1,
                    UnitPrice=products.Single( c=> c.Name == "Atlas Extended Vision Caboose").Price
                },

                new OrderLine {
                    OrderID = 3,
                    ProductID = products.Single( c=> c.Name == "Railway Tall Building").ID,
                    ProductName="Railway Tall Building",
                    Quantity=2,
                    UnitPrice=products.Single( c=> c.Name == "Railway Tall Building").Price
                },

                new OrderLine {
                    OrderID = 4,
                    ProductID = products.Single( c=> c.Name == "Kato Shinkansen N700a").ID,
                    ProductName="Kato Shinkansen N700a",
                    Quantity=1,
                    UnitPrice=products.Single( c=> c.Name == "Kato Shinkansen N700a").Price
                },

                new OrderLine {
                    OrderID = 5,
                    ProductID = products.Single( c=> c.Name == "Bachmann EZ Track").ID,
                    ProductName="Bachmann EZ Track",
                    Quantity=5,
                    UnitPrice=products.Single( c=> c.Name == "Bachmann EZ Track").Price
                }
            };

            orderLines.ForEach(c => context.OrderLines.AddOrUpdate(ol => ol.OrderID, c));
            context.SaveChanges();
        }
    }
}
