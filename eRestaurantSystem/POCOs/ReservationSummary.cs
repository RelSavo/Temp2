using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurantSystem.POCOs
{
    public class ReservationSummary
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string EventType { get; set; }
        public int NumberInParty { get; set; }
        public string Contact { get; set; }
    }
}
