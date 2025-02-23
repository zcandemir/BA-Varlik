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
    public  class UserDebitManager :Manager<UserDebitModel,UserDebit,UserDebitMappingProfiles>
    {
        public UserDebitManager() 
        {
            _repositories = new UserDebitRepositories(new ApplicationDbContext());
        }

    }
}
