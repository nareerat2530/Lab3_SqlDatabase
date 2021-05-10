using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3_SqlDatabase
{
    public partial class Shop
    {
        public Shop()
        {
            Orders = new HashSet<Order>();
            Staff = new HashSet<Staff>();
        }

        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
