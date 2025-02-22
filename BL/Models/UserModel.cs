using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class UserModel
    {

        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? TeamName { get; set; }

        public List<UserDebitModel> UserDebits { get; set; }
        public ICollection<DebitModel> DebitsReceived { get; set; }

        public ICollection<DebitModel> DebitsAssigned { get; set; }

    }
}
