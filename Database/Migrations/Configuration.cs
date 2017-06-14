namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Database.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<Database.BreakAwayContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Database.BreakAwayContext context)
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
            Destination destination = new Destination();
            destination.Country = "Canada";
            destination.Name = "HotelInn";
            Lodging lodgingFirst = new Lodging();
            lodgingFirst.Name = "Suhail";
            lodgingFirst.Owner = "Khan";
            lodgingFirst.IsResort = true;
            destination.Lodgings.Add(lodgingFirst);
            context.Destinations.AddOrUpdate(destination);
          
        }
    }
}
