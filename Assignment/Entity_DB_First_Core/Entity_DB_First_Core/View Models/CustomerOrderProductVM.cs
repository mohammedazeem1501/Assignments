using Entity_DB_First_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_DB_First_Core.View_Models
{
    public class CustomerOrderProductVM
    {
        public CustomerOrderProductVM()
        {
            Orders = new HashSet<Orders>();
            Product = new HashSet<Product>();
        }

        public string CustomerName { get; set; }
        public string Contact { get; set; }
        public DateTime? DateOrdered { get; set; }
        public decimal? Amount { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
