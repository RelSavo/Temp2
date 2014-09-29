using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
    using System.ComponentModel.DataAnnotations;
#endregion

namespace eRestaurantSystem.Entities
{
    public class Bill
    {
        [Key]
        public int BillID { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime OrderPlaced { get; set; }
        public int NumberInParty { get; set; }
        public bool PaidStatus { get; set; }
        public int WaiterID { get; set; }
        public int TableID { get; set; }
        public int ReservationID { get; set; }
        public bool OrderReady { get; set; }
        public string Comment { get; set; }

        //VIRTUAL NAVIGATIONS
        public virtual Waiter Waiter { get; set; }
    }
}
