using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DerekCore21MVC_Contoso.Models
{
    /// <summary>
    /// Name ?
    /// </summary>
    public class Customer
    {
        public int CustomerID { get; set; }

        [StringLength(50)]
        public String UserID { get; set; }

        [Required, StringLength(20)]
        [DisplayName("First Name")]
        public String FirstName { get; set; }

        [Required, StringLength(20)]
        [DisplayName("Last Name")]
        public String LastName { get; set; }

        [DisplayName("Email")]
        [Required, StringLength(50), DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set; }

        [Required, StringLength(20), DisplayName("Phone Number")]
        public String TelephoneNo { get; set; }

        public int AddressID { get; set; }

        // Navigation Properties

        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Address Address { get; set; }
    }
}