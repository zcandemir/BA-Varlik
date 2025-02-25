using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get ; set ; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        
        
    }
}
