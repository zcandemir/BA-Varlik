using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Abstract;
using BL.MappingProfiles;
using BL.Models;
using DAL.Entities;
using DAL.MyDbContext;
using DAL.Repositories.Concrete;

namespace BL.Concrete
{
    public class ProductManager :Manager<ProductModel,Product,ProductMappingProfiles>
    {
        public ProductManager() 
        {
            _repositories = new ProductRepositories(new ApplicationDbContext ());
        }     
    }
}
