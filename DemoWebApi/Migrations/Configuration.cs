namespace DemoWebApi.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DemoWebApi.Models.DemoWebApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DemoWebApi.Models.DemoWebApiContext context)
        {
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

            
            context.Products.AddOrUpdate(x => x.Id,
                new Product() { Id = 1, Category = "Fruit", Name = "Apricot", Price = 3.5M },
                new Product() { Id = 2, Category = "Fruit", Name = "Apple", Price = 2.5M },
                new Product() { Id = 3, Category = "Fruit", Name = "Pear", Price = 3.2M }
                );
                

        }
    }
}
