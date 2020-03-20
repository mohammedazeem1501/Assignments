using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace entity_advance.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNo { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}