namespace ECommerceApplication.DataLayer.Entities
{
    /// <summary>
    /// Base class for db entities.
    /// </summary>
    public abstract class DbEntity
    {
        /// <summary>
        /// The unique identifier.
        /// </summary>
        public int Id { get; set; }
    }
}
