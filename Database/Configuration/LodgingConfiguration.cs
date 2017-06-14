using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Database.Model;

namespace Database.Configuration
{
    public class LodgingConfiguration : EntityTypeConfiguration<Lodging>
    {
        public LodgingConfiguration()
        {
            Property(l => l.Name)
              .IsRequired()
              .HasMaxLength(200);

            HasRequired(l => l.Destination)
                .WithMany(l => l.Lodgings)
                .HasForeignKey(l => l.DestinationId);

                
        }
    }
}