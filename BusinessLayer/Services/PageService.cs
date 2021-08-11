using ECommerceApplication.BusinessLayer.Services;
using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.DataLayer.Interfaces;

namespace ECommerceApplication.BusinessLayer.Services
{
    public class PageService : AbstractService<Page>, IPageService
    {
        private readonly IPageRepository _pageRepo;

        public PageService(IPageRepository pageRepo) : base(pageRepo)
        {
            _pageRepo = pageRepo;

        }
    }
}
