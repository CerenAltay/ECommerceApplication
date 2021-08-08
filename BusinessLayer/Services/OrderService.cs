using BusinessLayer.Services;
using DataLayer.Entities;
using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.DataLayer.Interfaces;

namespace ECommerceApplication.BusinessLayer.Services
{
    public class OrderService : AbstractService<Order>, IOrderService
    {
        private readonly IOrderRepository _orderRepo;

        public OrderService(IOrderRepository orderRepo) : base(orderRepo)
        {
            _orderRepo = orderRepo;

        }
    }
}
