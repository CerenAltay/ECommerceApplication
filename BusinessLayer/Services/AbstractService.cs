using AutoMapper;
using BusinessLayer.Interfaces;
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
        //private readonly IRepository<T> _repository;
        protected readonly IMapper Mapper;

        public Task<IEnumerable<T>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
