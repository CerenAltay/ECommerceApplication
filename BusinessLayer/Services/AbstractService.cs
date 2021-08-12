using AutoMapper;
using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.DataLayer.Interfaces;
using ECommerceApplication.DataLayer.Repositories;
using ECommerceApplication.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApplication.BusinessLayer.Models;

namespace ECommerceApplication.BusinessLayer.Services
{
   public abstract class AbstractService<T, TDto> : IAbstractService<TDto>
        where T : DbEntity
       where TDto :DomainObject
    {
        private readonly IRepository<T> _repository;

        protected readonly IMapper _mapper;

        protected AbstractService(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
             _mapper = mapper;
        }

        public async Task Add(TDto id)
        {
            return await _repository.Add(id);
        }

        public async Task<IEnumerable<T>> Get()
        {
            var x = await _repository.Get();

            var my = _mapper.Map<IEnumerable<T>>(x);
            return my;
            //return await _repository.Get()
            //    .ProjectTo<TDo>(mapper.ConfigurationProvider);
        }

        public async Task<TDto> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(TDto item)
        {
            throw new NotImplementedException();
        }
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
