using System;
using System.Collections.Generic;

namespace Entity_DB_First_Core.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
