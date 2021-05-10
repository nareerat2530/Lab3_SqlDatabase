using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3_SqlDatabase
{
    public partial class TopThreeCustomer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int? AmountOrders { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
