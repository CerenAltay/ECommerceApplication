using DataLayer;
using DataLayer.Entities;
using ECommerceApplication.DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        protected readonly ECommerceAppContext context;
        public OrderRepository(ECommerceAppContext context)
        {
            this.context = context;
        }

        public Task Add(Order item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> Get()
        {
            return await context.Orders.OrderBy(x => x.Id).ToListAsync();
        }

        public Task<Order> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
