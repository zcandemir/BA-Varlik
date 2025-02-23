using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models.Abstract;

namespace BL.Models
{
    public class WareHouseModel:BaseModel
    {
        public string Name { get; set; }

        public List<ProductModel> Product { get; set; }
    }
}
