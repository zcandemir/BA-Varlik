using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models.Abstract;

namespace BL.Models
{
    public class UserDebitModel:BaseModel
    {
        public int DebitId { get; set; }
        public int UserId { get; set; }

        public UserModel User { get; set; }
        public DebitModel Debit { get; set; }
    }
}
