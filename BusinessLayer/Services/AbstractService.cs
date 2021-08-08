using AutoMapper;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
   public abstract class AbstractService<T> : IAbstractService<T>
        where T : class
    {
        private readonly IRepository<T> _repository;

        //protected readonly IMapper Mapper;

        protected AbstractService(IRepository<T> repository)
        {
            _repository = repository;
           // Mapper = mapper;
        }
        public async Task<IEnumerable<T>> Get()
        {
            return await _repository.Get();
        }

        //public async Task<T> GetById(int id)
        //{
        //    return await _repository.GetById(id);
        //}
    }
}
