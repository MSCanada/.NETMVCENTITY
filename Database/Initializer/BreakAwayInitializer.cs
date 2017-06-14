using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Database.Model;

namespace Database.Initializer
{
    public class BreakAwayInitializer: CreateDatabaseIfNotExists<BreakAwayContext>
    {
        protected override void Seed(BreakAwayContext context)
        {
            Destination destination = new Destination();
            destination.Country = "Canada";
            destination.Name = "HotelInn";
            Lodging lodgingFirst = new Lodging();
            lodgingFirst.Name = "Suhail";
            lodgingFirst.Owner = "Khan";
            lodgingFirst.IsResort = true;
            destination.Lodgings.Add(lodgingFirst);
            context.Destinations.Add(destination);
            base.Seed(context);
        }
    }
}