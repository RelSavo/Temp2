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
        public DbSet<MenuCategory> MenuCategory { get; set; }
        public DbSet<Item> Items { get; set; }


        #region Over-ride OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reservations>().HasMany(r => r.Tables)
                .WithMany(t => t.Reservations)
                .Map(mapping =>
                {
                    mapping.ToTable("ReservationTables");
                    mapping.MapLeftKey("ReservationID");
                    mapping.MapRightKey("TableID");
                });
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
