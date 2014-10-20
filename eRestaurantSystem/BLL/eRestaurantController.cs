using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
    using eRestaurantSystem.Entities;
    using eRestaurantSystem.DAL;
    using eRestaurantSystem.DTOs;
    using System.ComponentModel;
#endregion

namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class eRestaurantController
    {

        #region SpecialEvents

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> SpecialEvent_List ()
        {
            //Interfacing with the Context class which inherits
            using (eRestaurantContext context = new eRestaurantContext())
            {
                //Using Context DbSet to get entity data.
                //CODE: return context.SpecialEvents.ToList();

                //Get a list of instances for entity using LINQ
                var results = from item in context.SpecialEvents
                              select item;
                return results.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SpecialEvent SpecialEventByEventCode(string eventCode)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                return context.SpecialEvents.Find(eventCode);
            }
        }

        //ADD
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void SpecialEvents_Add(SpecialEvent item)
        {
            using(eRestaurantContext context = new eRestaurantContext())
            {
                SpecialEvent added = null;
                added = context.SpecialEvents.Add(item);
                context.SaveChanges();                                                  //Commits the add to the database.
                                                                                        //Furthermore, this evaluates the annotations (validates) on the entity.
                                                                                        //Included: [Required], [StringLength], [Range], etc.
            }
        }

        //UPDATE
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void SpecialEvents_Update(SpecialEvent item)
        {
            using(eRestaurantContext context = new eRestaurantContext())
            {
                context.Entry<SpecialEvent>(context.SpecialEvents.Attach
                (item)).State = System.Data.Entity.EntityState.Modified;
                
                context.SaveChanges();
            }
        }

        //DELETE
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void SpecialEvents_Delete(SpecialEvent item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                SpecialEvent existing = context.SpecialEvents.Find(item.EventCode);
                context.SpecialEvents.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion

        #region Reservations
        
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservations> Reservation_List ()
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                return context.Reservations.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservations> ReservationByEvent(string eventCode)
        {
            using (eRestaurantContext Context = new eRestaurantContext())
            {
                //Foreach rowIndicator the EventCode must equal the passed in event code.
                return Context.Reservations.Where(rowIndicator => rowIndicator.EventCode == eventCode).ToList();
            }
        }

        //ADD
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void Reservations_Add(Reservations item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                Reservations added = null;
                added = context.Reservations.Add(item);
                context.SaveChanges();                                                  //Commits the add to the database.
                //Furthermore, this evaluates the annotations (validates) on the entity.
                //Included: [Required], [StringLength], [Range], etc.
            }
        }

        //UPDATE
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Reservations_Update(Reservations item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                context.Entry<Reservations>(context.Reservations.Attach
                (item)).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
        }

        //DELETE
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void Reservations_Delete(Reservations item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                Reservations existing = context.Reservations.Find(item.ReservationID);
                context.Reservations.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        
        #region Waiter
        //LIST
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Waiter> Waiter_List()
        {
            //Interfacing with the Context class which inherits
            using (eRestaurantContext context = new eRestaurantContext())
            {
                //Using Context DbSet to get entity data.
                //CODE: return context.SpecialEvents.ToList();

                //Get a list of instances for entity using LINQ
                var results = from item in context.Waiter
                              select item;
                return results.ToList();
            }
        }


        //Get Waiter by ID
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Waiter GetWaiter(int waiterID)
        {
            using (eRestaurantContext Context = new eRestaurantContext())
            {
                //Foreach rowIndicator the EventCode must equal the passed in event code.
                return Context.Waiter.Find(waiterID);
            }
        }


        //ADD
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void Waiter_Add(Waiter item)
        {
            using(eRestaurantContext context = new eRestaurantContext())
            {
                Waiter added = null;
                added = context.Waiter.Add(item);
                context.SaveChanges();                                                  //Commits the add to the database.
                                                                                        //Furthermore, this evaluates the annotations (validates) on the entity.
                                                                                        //Included: [Required], [StringLength], [Range], etc.
            }
        }

        //UPDATE
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Waiter_Update(Waiter item)
        {
            using(eRestaurantContext context = new eRestaurantContext())
            {
                context.Entry<Waiter>(context.Waiter.Attach
                (item)).State = System.Data.Entity.EntityState.Modified;
                
                context.SaveChanges();
            }
        }

        //DELETE
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void Waiter_Delete(Waiter item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                Waiter existing = context.Waiter.Find(item.WaiterID);
                context.Waiter.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion

        #region Bill
        //ADD
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void Bill_Add(Bill item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                Bill added = null;
                added = context.Bill.Add(item);
                context.SaveChanges();                                                  //Commits the add to the database.
                                                                                        //Furthermore, this evaluates the annotations (validates) on the entity.
                                                                                        //Included: [Required], [StringLength], [Range], etc.
            }
        }

        //UPDATE
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Bill_Update(Bill item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                context.Entry<Bill>(context.Bill.Attach
                (item)).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
        }

        //DELETE
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void Bill_Delete(Bill item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                Bill existing = context.Bill.Find(item.BillID);
                context.Bill.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion

        #region LINQ Queries
            [DataObjectMethod(DataObjectMethodType.Select, false)]
            public List<DTOs.CategoryMenuItems> GetCategoryMenuItems()
            {
                using(eRestaurantContext context = new eRestaurantContext())
                { 
                    var results = from category in context.MenuCategory
                                  orderby category.Description
                                  select new DTOs.CategoryMenuItems()
                                  {
                                      Description = category.Description,
                                      MenuItem = from rowItem in category.Item
                                                 where rowItem.Active
                                                 select new MenuItem()
                                                 {
                                                     Description = rowItem.Description,
                                                     CurrentPrice = rowItem.CurrentPrice,
                                                     Calories = rowItem.Calories,
                                                     Comment = rowItem.Comment
                                                 }
                                  };

                    return results.ToList();
                }
            }
        #endregion
    }
}
