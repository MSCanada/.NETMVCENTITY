using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database.Model
{
    public class Lodging
    {
        public int LodgingId { get; set; }
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public bool IsResort { get; set; }
        public Destination Destination { get; set; }
    }
}