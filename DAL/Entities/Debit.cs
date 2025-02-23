using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities.Abstract;

namespace DAL.Entities
{
    public  class Debit:BaseEntity
    {
        public string Explanation { get; set; }

        public int AssigninguserId { get; set; }
        public int AssigneduserId { get; set; }
        public int ProductId { get; set; }
        public  Product Product { get; set; }
        public  User AssigningUser { get; set; }
        public  User AssignedUser { get; set; }
    }
}
