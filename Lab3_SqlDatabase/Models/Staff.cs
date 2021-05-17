using System.Collections.Generic;

#nullable disable

namespace Lab3_SqlDatabase
{
    public class Staff
    {
        public Staff()
        {
            InverseManager = new HashSet<Staff>();
            Orders = new HashSet<Order>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int ShopId { get; set; }
        public int? ManagerId { get; set; }

        public virtual Staff Manager { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual ICollection<Staff> InverseManager { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}