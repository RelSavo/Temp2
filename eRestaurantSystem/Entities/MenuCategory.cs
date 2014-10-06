using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
    using System.ComponentModel.DataAnnotations;
    using System.Collections;
#endregion

namespace eRestaurantSystem.Entities
{
    public class MenuCategory
    {
        [Key]
        public int MenuCategoryID { get; set; }
        
        public string Description { get; set; }
        public IEnumerable Items { get; set; }

        //Navigation
        public virtual ICollection<Item> Item { get; set; }

    }
}
