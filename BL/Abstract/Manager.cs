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
    public abstract class Manager<TModel, TEntity, TMappingProfile> : IManager<TModel>
        where TMappingProfile : Profile, new()
        where TEntity : IEntity
        where TModel : IModel
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
        public bool Add(TModel model)
        {
            try
            {
                TEntity entity = _mapper.Map<TEntity>(model);
                _repositories.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
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

        void IManager<TModel>.Remove(int id)
        {
            _repositories.Remove(id);
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

        
    }
}
