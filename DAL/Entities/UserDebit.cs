using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities.Abstract;

namespace DAL.Entities
{
    public class UserDebit : BaseEntity
    {
        public int DebitId { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public Debit Debit { get; set; }


    }
}
