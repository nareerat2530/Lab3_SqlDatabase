using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3_SqlDatabase
{
    public partial class Order
    {
        public Order()
        {
            Orderdetails = new HashSet<Orderdetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShopId { get; set; }
        public int StaffId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
