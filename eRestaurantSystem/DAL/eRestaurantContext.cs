using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
    using eRestaurantSystem.Entities;
    using System.Data.Entity;
#endregion

namespace eRestaurantSystem.DAL
{
    internal class eRestaurantContext : DbContext                                       //Hookup to Entity Framework through the DbContext base class.
    {
        //Constructors
        public eRestaurantContext() : base("name=EatIn") { }                            //ConnectionString to the database found in web config.

        public DbSet<SpecialEvent> SpecialEvents { get; set; }                          //DBSets are created for each entit; to be referenced by the application.
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<Waiter> Waiter { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<MenuCategory> menuCategory { get; set; }
        public DbSet<Item> items { get; set; }
    }
}
