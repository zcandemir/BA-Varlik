using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models.Abstract;

namespace BL.Models
{
    public class DebitModel: BaseModel
    {
        
        public string Explanation { get; set; }
        public bool IsActive { get; set; }
        public int AssigninguserId { get; set; }
        public int AssigneduserId { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public UserModel AssigningUser { get; set; }
        public UserModel AssignedUser { get; set; }
    }
}
