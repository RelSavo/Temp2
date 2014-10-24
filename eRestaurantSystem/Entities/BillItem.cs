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
    public class BillItem
    {
        [Key]
        public int BillID { get; set; }

        [Required]
        public int ItemID { get; set; }

        public int Quantity { get; set; }

        public decimal SalePrice { get; set; }

        public decimal UnitCost { get; set; }

        public string Notes { get; set; }

        //Navigations
        public virtual Item Item { get; set; }

    }
}
