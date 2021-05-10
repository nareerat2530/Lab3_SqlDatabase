using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3_SqlDatabase
{
    public partial class Stock
    {
        public int ShopId { get; set; }
        public string IsbnId { get; set; }
        public int? Quantity { get; set; }

        public virtual Book Isbn { get; set; }
    }
}
