using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.MyDbContext;
using DAL.Repositories.Abstract;

namespace DAL.Repositories.Concrete
{
    internal class UserRepositories:Repositories<User>
    {
        public UserRepositories(ApplicationDbContext context):base(context) { }
    }
}
