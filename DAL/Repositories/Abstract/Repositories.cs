using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities.Abstract;

using DAL.MyDbContext;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Abstract
{
    public abstract class Repositories<T> : IRepositories<T> where T : BaseEntity, new()
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> entities;

        public Repositories(ApplicationDbContext context)
        {
            _context = context;
            entities = _context.Set<T>();

        }

        public void Add(T entity)
        { 
            entity.CreatedDate = DateTime.Now;
            entities.Add(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        { 
            return entities.AsNoTracking();
        }

        public IQueryable<T> GetAllWithIncludes()
        {

            IQueryable<T> query = _context.Set<T>().AsNoTracking();
            T instance = new T();

            var type = instance.GetType();
            var properties = type.GetProperties();

            foreach (var propertyInfo in properties.Where(pi => pi.PropertyType.GetInterfaces().Where(i => i.Name == "IEntity" || i.Name == "IList").Any()).ToList())
            {
                query = query.Include(propertyInfo.Name);
            }

            return query;

        }

        public T GetById(int id)
        { 
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id );
        }

        public void Remove(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                entities.Remove(entity);
            }
            _context.SaveChanges();
        }

        public void Update(T entity)
        {

            entity.CreatedDate = GetById(entity.Id).CreatedDate;

            foreach (var item in _context.ChangeTracker.Entries())
            {
                if (item.Entity.GetType() == typeof(T))
                {
                    item.State = EntityState.Detached;
                }
            }
            entity.UpdatedDate = DateTime.Now;
            _context.Update(entity);
            _context.SaveChanges();


        }
    }
}
