namespace ECommerceApplication.DataLayer.Entities
{
    /// <summary>
    /// An item in the order.
    /// </summary>
    public class OrderItem : DbEntity
    {
        /// <summary>
        /// Id of the parent order.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Navigation property to the order.
        /// </summary>
        public virtual Order Order { get; set; }

        /// <summary>
        /// Id of the to product table.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// The product.
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// The quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The line total.
        /// </summary>
        public double NetTotal { get; set; }
    }
}
