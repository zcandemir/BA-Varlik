using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities.Abstract;
using DAL.Enums;
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

        public void Delete(T entity)
        {


            if (entity.UpdatedDate != null)
                entity.UpdatedDate = GetById(entity.Id).UpdatedDate;

            entity.Status = DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;
            Update(entity);
        }

        public void RecoverDeleted(T entity)
        {




            entity.DeletedDate = null;
            entity.Status = DataStatus.Updated;

            entity.CreatedDate = GetDeletedById(entity.Id).CreatedDate;
            entity.UpdatedDate = DateTime.Now;



            foreach (var item in _context.ChangeTracker.Entries())
            {
                if (item.Entity.GetType() == typeof(T))
                {
                    item.State = EntityState.Detached;

                }


            }


            _context.Update(entity);
            _context.SaveChanges();

        }

        public IQueryable<T> GetAll()
        {

            return entities.AsNoTracking().Where(e => e.Status != DataStatus.Deleted);
        }



        public IQueryable<T> GetAllWithIncludes()
        {


            IQueryable<T> query = _context.Set<T>().AsNoTracking();


            T instance = new T();


            var type = instance.GetType();


            var properties = type.GetProperties();



            foreach (var propertyInfo in properties.Where(pi => pi.PropertyType.GetInterfaces().Where(i => i.Name == "IEntity" || i.Name == "IList").Any()).ToList())
            {
                if (propertyInfo.Name == "Product")
                    query = query.Include(propertyInfo.Name + ".Brand");
                else
                    query = query.Include(propertyInfo.Name);
            }



            return query;

        }

        public T GetById(int id)
        {

            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.Status != DataStatus.Deleted);
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

        public IQueryable<T> Search(Expression<Func<T, bool>> predicate)
        {


            return GetAll().Where(predicate);
        }

        public void Update(T entity)
        {
            if (entity.Status != DataStatus.Deleted)
            {
                entity.Status = DataStatus.Updated;
                entity.UpdatedDate = DateTime.Now;
            }



            entity.CreatedDate = GetById(entity.Id).CreatedDate;



            foreach (var item in _context.ChangeTracker.Entries())
            {
                if (item.Entity.GetType() == typeof(T))
                {
                    item.State = EntityState.Detached;

                }


            }


            _context.Update(entity);
            _context.SaveChanges();


        }

        public T GetDeletedById(int id)
        {

            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.Status == DataStatus.Deleted);
        }

        public IQueryable<T> GetAllDeleted()
        {

            return entities.AsNoTracking().Where(e => e.Status == DataStatus.Deleted);
        }

        public T GetByIdwithIncludes(int id)
        {

            return GetAllWithIncludes().Where(u => u.Status != DataStatus.Deleted).FirstOrDefault(u => u.Id == id);
        }

        public IQueryable<T> GetAllWithSelectedIncludes(params string[] navigationProperties)
        {


            IQueryable<T> query = _context.Set<T>();

            foreach (var navigationProperty in navigationProperties)
                query = query.Include(navigationProperty);

            return query;
        }



    }
}
