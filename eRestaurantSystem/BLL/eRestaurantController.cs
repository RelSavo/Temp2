using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
    using eRestaurantSystem.Entities;
    using eRestaurantSystem.DAL;
    using System.ComponentModel;
#endregion

namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class eRestaurantController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> SpecialEvent_List ()
        {
            //Interfacing with the Context class which inherits
            using (eRestaurantContext context = new eRestaurantContext())
            {
                return context.SpecialEvents.ToList();
            }
        }
    }
}
