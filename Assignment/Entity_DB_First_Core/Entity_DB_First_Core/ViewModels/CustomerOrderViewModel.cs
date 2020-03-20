using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_DB_First_Core.ViewModels
{
    public class CustomerOrderViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public int Order_Id { get; set; }
        public DateTime? DateOrdered { get; set; }
        public decimal? Amount { get; set; }
    }
}
