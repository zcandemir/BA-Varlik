using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class WareHouseModel
    {
        public string Name { get; set; }

        public List<ProductModel> Product { get; set; }
    }
}
