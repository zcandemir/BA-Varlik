using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    internal interface IManager<TModel>
    {
        void Add(TModel model);

        void Update(TModel model);

        TModel GetById(int id);

        void Delete(TModel model);

        void RecoverDeleted(TModel model);

        void Remove(TModel model);

        List<TModel> GetAll();

        List<TModel> GetAllWithIncludes();

        List<TModel> Search(Expression<Func<TModel, bool>> predicate);

        public TModel GetDeletedById(int id);

        public List<TModel> GetAllDeleted();

        public TModel GetByIdwithIncludes(int id);

        public List<TModel> GetAllWithSelectedIncludes(params string[] navigationProperties);
    }
}
