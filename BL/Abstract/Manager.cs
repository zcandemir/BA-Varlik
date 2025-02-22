using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using BL.Models.Abstract;
using DAL.Entities.Abstract;
using DAL.Repositories.Abstract;

namespace BL.Abstract
{
    internal abstract class Manager<TModel, TEntity, TMappingProfile> : IManager<TModel>
        where TMappingProfile : Profile, new()
        where TEntity : IEntity
        where TModel:IModel
    {

        private IMapper _mapper;
        protected IRepositories<TEntity> _repositories;
        private MapperConfiguration _config;


        public Manager()
        {
            _config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap();
                cfg.AddProfile<TMappingProfile>();

            });
            _mapper = new Mapper(_config);
        }
        public void Add(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repositories.Add(entity);
        }

        void IManager<TModel>.Delete(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repositories.Delete(entity);
        }

        List<TModel> IManager<TModel>.GetAll()
        {
            var entities = _repositories.GetAll().ToList();
            List<TModel> models = _mapper.Map<List<TModel>>(entities);
            return models;
        }

        TModel IManager<TModel>.GetById(int id)
        {
            var entity = _repositories.GetById(id);
            var model = _mapper.Map<TModel>(entity);
            return model;
        }

        void IManager<TModel>.Remove(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repositories.Remove(entity);
        }

        List<TModel> IManager<TModel>.Search(Expression<Func<TModel, bool>> predicate)
        {
            var predicateForEntity = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
            var entities = _repositories.Search(predicateForEntity);
            var models = _mapper.Map<List<TModel>>(entities);
            return models;
        }

        void IManager<TModel>.Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repositories.Update(entity);
        }

        public List<TModel> GetAllWithIncludes()
        {
            var entities = _repositories.GetAllWithIncludes().ToList();
            List<TModel> models = _mapper.Map<List<TModel>>(entities);
            return models;
        }

        public void RecoverDeleted(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repositories.RecoverDeleted(entity);
        }

        public TModel GetDeletedById(int id)
        {
            var entity = _repositories.GetDeletedById(id);
            var model = _mapper.Map<TModel>(entity);
            return model;
        }

        public List<TModel> GetAllDeleted()
        {
            var entities = _repositories.GetAllDeleted().ToList();
            List<TModel> models = _mapper.Map<List<TModel>>(entities);
            return models;
        }

        public TModel GetByIdwithIncludes(int id)
        {
            var entity = _repositories.GetByIdwithIncludes(id);
            var model = _mapper.Map<TModel>(entity);
            return model;
        }

        public List<TModel> GetAllWithSelectedIncludes(params string[] navigationProperties)
        {
            var entities = _repositories.GetAllWithSelectedIncludes(navigationProperties).ToList();
            List<TModel> models = _mapper.Map<List<TModel>>(entities);
            return models;
        }
    }
}
