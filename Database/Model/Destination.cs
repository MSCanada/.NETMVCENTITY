using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database.Model
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public List<Lodging> Lodgings { get; set; }

        public Destination() {
            Lodgings = new List<Lodging>();
        }
    }
}