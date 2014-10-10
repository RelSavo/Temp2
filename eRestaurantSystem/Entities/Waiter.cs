using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
#endregion

//GOOD TO KNOW
//----------------------------------------------------
//TimeSpan - Only holds time
//DayOfWeek - Enum. (0 = Sunday through 6 = Saturday)

namespace eRestaurantSystem.Entities
{
    public class Waiter
    {
        [Key]
        public int WaiterID { get; set; }

        //First Name
        [Required(ErrorMessage="A first name is required.")]
        [StringLength(25, ErrorMessage="First name can be up to 25 characters.")]
        public string FirstName { get; set; }

        //Last Name
        [Required(ErrorMessage = "A last name is required.")]
        [StringLength(35, ErrorMessage = "Last name can be up to 35 characters.")]
        public string LastName { get; set; }

        //Phone Number
        [Required(ErrorMessage = "A phone number is required.")]
        [StringLength(15, ErrorMessage = "Maximum 15 numbers.")]
        public string Phone { get; set; }

        //Address
        [Required(ErrorMessage = "An address is required.")]
        [StringLength(30, ErrorMessage = "Maximum 30 numbers.")]
        public string Address { get; set; }

        //Hire Date
        [Required(ErrorMessage="A hire date must be entered.")]
        public DateTime HireDate { get; set; }
        
        //Release Date
        public DateTime ReleaseDate { get; set; }


        //Read only Property
        [NotMapped]
        public string FullName
        {
            get
            {
                return string.Format("{0}, {1}", FirstName, LastName);
            }
        }

        //VIRTUAL NAVIGATIONS

        //Bill
        public virtual ICollection<Bill> Bills { get; set; }
        

    }
}