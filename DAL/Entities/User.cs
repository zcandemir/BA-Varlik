using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace DAL.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? TeamName { get; set; }

        public List<UserDebit> UserDebits { get; set; }
        public ICollection<Debit> DebitsReceived { get; set; }

        public ICollection<Debit> DebitsAssigned { get; set; }

    }
}
