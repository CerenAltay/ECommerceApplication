using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Repositories
{
    public class PageRepository : AbstractRepository<Page>, IPageRepository
    {
        public PageRepository(ECommerceAppContext db) : base(db) { }

        //protected readonly ECommerceAppContext context;
        //public PageRepository(ECommerceAppContext context)
        //{
        //    this.context = context;
        //}

        //public async Task<IEnumerable<Page>> Get()
        //{
        //    return await context.Pages.OrderBy(x => x.Id).ToListAsync();
        //}
    }
}
