//using AutoMapper;
//using BusinessLayer.Interfaces;
//using DataLayer.Interfaces;
//using DataLayer.Repositories;
//using ECommerceApplication.BusinessLayer.Models;
//using ECommerceApplication.DataLayer.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessLayer.Services
//{
//   public abstract class AbstractService<TEntity, TDTO> : IAbstractService<TDTO>
//        where TEntity : DbEntity
//        where TDTO : DomainObject
//    {
//        private readonly IRepository<TEntity> _repository;

//        //protected readonly IMapper Mapper;

//        protected AbstractService(IRepository<TEntity> repository)
//        {
//            _repository = repository;
//           // Mapper = mapper;
//        }

//        public  async Task Add(T id)
//        {
//            return await _repository.Add(T.Id);
//        }

//        public async Task Delete(T id)
//        {
//            return await _repository.Get();
//        }

//        public async Task<IEnumerable<T>> Get()
//        {
//            return await _repository.Get();
//        }

//        public async Task<TEntity> GetById(int id)
//        {
//            return await _repository.Get(id);
//        }

//        public async Task Update(int id)
//        {
//            return await _repository.Update(id);
//        }

       
//    }
//}
