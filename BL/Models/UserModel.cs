using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models.Abstract;

namespace BL.Models
{
    public class UserModel:BaseModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? TeamName { get; set; }

        public List<UserDebitModel> UserDebits { get; set; }
    }
}
