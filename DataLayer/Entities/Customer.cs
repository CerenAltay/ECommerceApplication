using System.Collections.Generic;

namespace ECommerceApplication.DataLayer.Entities
{
    public class Customer : DbEntity
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string Name { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// The customer's orders.
        /// </summary>
        public ICollection<Order> Orders { get; set; }
    }
}
