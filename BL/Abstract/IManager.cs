using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public interface IManager<TModel>
    {
        bool Add(TModel model);

        void Update(TModel model);

        TModel GetById(int id);
        void Remove(int id);

        List<TModel> GetAll();

        List<TModel> GetAllWithIncludes();

        

        

        

        

       
    }
}
