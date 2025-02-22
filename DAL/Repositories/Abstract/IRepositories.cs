using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstract
{
    public interface IRepositories <T>
    {
        public void Add(T entity);



        public void Update(T entity);



        public T GetById(int id);


        public T GetByIdwithIncludes(int id);



        public T GetDeletedById(int id);



        public void Delete(T entity);


        public void Remove(T entity);



        public IQueryable<T> GetAll();


        public IQueryable<T> GetAllDeleted();


        public IQueryable<T> Search(Expression<Func<T, bool>> predicate);



        public IQueryable<T> GetAllWithIncludes();



        public IQueryable<T> GetAllWithSelectedIncludes(params string[] navigationProperties);



        public void RecoverDeleted(T entity);
    }
}
