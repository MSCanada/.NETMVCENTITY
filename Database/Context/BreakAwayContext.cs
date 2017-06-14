namespace Database
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Database.Configuration;
    using Database.Initializer;
    using Database.Model;

    public class BreakAwayContext : DbContext
    {
       
        public BreakAwayContext()
            : base("name=BreakAwayContext")
        {
            Database.SetInitializer(new BreakAwayInitializer());
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DestinationConfiguration());
            modelBuilder.Configurations.Add(new LodgingConfiguration());
        }

    }

   
}