using System;
using System.Collections.Generic;

namespace Entity_DB_First_Core.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
