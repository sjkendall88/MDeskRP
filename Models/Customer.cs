using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDeskRP.Models
{
    public class Customer
    {
        /// <summary>
        /// Parameter free Constructor
        /// </summary>
        /// <remarks>
        /// Required for scaffolding the UI
        /// </remarks>
        public Customer() { }

        /// <summary>
        /// Primary Key 
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// customer  first name
        /// </summary>
        [RegularExpression(@"^[a-zA-Z]+$")]
        [MinLength(2), MaxLength(24), Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        /// <summary>
        /// customer last name
        /// </summary>
        [RegularExpression(@"^[a-zA-Z]+$")]
        [MinLength(2), MaxLength(24), Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        /// <summary>
        /// customer phone number
        /// </summary>
        [RegularExpression(@"^[0-9]+$")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// customer street 
        /// </summary>
        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Street")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// customer city
        /// </summary>
        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "City")]
        public string CityAddress { get; set; }

        /// <summary>
        /// customer state
        /// </summary>
        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "State")]
        public string StateAddress { get; set; }

        /// <summary>
        /// date desk ordered
        /// </summary>
        [DataType(DataType.Date)]
        [Display(Name = "Order date")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// List of Desks
        /// </summary>
        public List<DeskQuote> DeskQuotes { get; set; }
    }
}
