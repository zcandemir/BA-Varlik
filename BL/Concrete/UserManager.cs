using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Abstract;
using BL.MappingProfiles;
using BL.Models;
using DAL.Entities;
using DAL.MyDbContext;
using DAL.Repositories.Concrete;

namespace BL.Concrete
{
    public  class UserManager: Manager<UserModel,User,UserMappingProfiles>
    {

        public UserManager() 
        {
            _repositories = new UserRepositories(new ApplicationDbContext());
        }

    }
}
