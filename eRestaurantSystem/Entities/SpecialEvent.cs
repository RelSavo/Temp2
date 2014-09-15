using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
    using System.ComponentModel.DataAnnotations;                                        //Handles Annotations for Entity Framework.
#endregion

namespace eRestaurantSystem.Entities
{
    //Remember All Classes are private by default.
    public class SpecialEvent
    {
        //Accessors
        [Key]                                                                           //Sets the following property as a primary key.
        public char EventCode { get; set; }                                             //Primary Key
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
