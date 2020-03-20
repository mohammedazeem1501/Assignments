using System;
using System.Collections.Generic;

namespace Entity_DB_First_Core.Models
{
    public partial class Orders
    {
        public int Id { get; set; }
        public DateTime? DateOrdered { get; set; }
        public decimal? Amount { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
