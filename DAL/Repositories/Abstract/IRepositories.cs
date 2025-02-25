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
        public void Remove(int id);
        public IQueryable<T> GetAll();
        public IQueryable<T> GetAllWithIncludes();

    }
}
