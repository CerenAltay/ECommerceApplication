using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Entities
{
    /// <summary>
    /// A order placed by a customer.
    /// </summary>
    public class Order : DbEntity
    {
        public Order()
        {
            Items = new HashSet<OrderItem>();
        }

        /// <summary>
        /// FK of the customer that placed the order
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// The net total of the price.
        /// </summary>
        public double TotalNetPrice { get; set; }

        /// <summary>
        /// The items.
        /// </summary>
        public ICollection<OrderItem> Items { get; set; }
    }
}
