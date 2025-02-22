using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities.Abstract;

namespace DAL.Entities
{
    public class WareHouse:BaseEntity
    {
        public string Name { get; set; }

        public List<Product> Product { get; set; }
    }
}
