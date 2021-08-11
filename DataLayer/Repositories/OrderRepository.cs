using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.DataLayer.Interfaces;
using ECommerceApplication.DataLayer.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ECommerceApplication.DataLayer.Repositories
{
    public class OrderRepository : AbstractRepository<Order>,IOrderRepository
    {
        public OrderRepository(ECommerceAppContext db) : base(db) { }
    }
}
