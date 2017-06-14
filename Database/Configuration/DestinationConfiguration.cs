using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Database.Model;

namespace Database.Configuration
{
    public class DestinationConfiguration : EntityTypeConfiguration<Destination>
    {
        public DestinationConfiguration()
        {
            Property(d => d.Name)
              .IsRequired();

            Property(d => d.Description)
              .HasMaxLength(400);

            Property(d => d.Photo)
              .HasColumnType("image");

           
        }
    }
}