using AutoMapper;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using ECommerceApplication.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
   public abstract class AbstractService<T> : IAbstractService<T>
        where T : DbEntity
    {
        private readonly IRepository<T> _repository;

        //protected readonly IMapper Mapper;

        protected AbstractService(IRepository<T> repository)
        {
            _repository = repository;
           // Mapper = mapper;
        }

        public Task Add(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _repository.Get();
        }

        public async Task<T> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public Task Update(T item)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
