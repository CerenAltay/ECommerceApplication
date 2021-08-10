using ECommerceApplication.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IRepository<T , TEntity> 
        where T: class
       where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> Get();
        public Task<TEntity> GetById(int id);
        public Task Add(TEntity item);
        public Task Update(TEntity item);
        public Task Delete(int id);


        //public Task Add(T item)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task Delete(Category item)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<Category>> Get()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Category> GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}


        //public Task Update(Category item)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
