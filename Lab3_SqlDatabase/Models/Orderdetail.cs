using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3_SqlDatabase
{
    public partial class Orderdetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string IsbnId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }

        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
    }
}
