using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel.Models
{
    class Flights
    {
        public int Id { get; set; }
        public string Code_Origin { get; set; }
        public string From_City { get; set; }
        public string Code_Destination { get; set; }
        public string To_City { get; set; }
        public string Departure_Time { get; set; }
        public string Arrival_Time { get; set; }
        public double Price { get; set; }

    }
}
