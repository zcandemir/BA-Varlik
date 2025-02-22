using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.Models;
using DAL.Entities;

namespace BL.MappingProfiles
{
    public  class UserDebitMappinProfiles:Profile
    {

        UserDebitMappinProfiles()
        {
            CreateMap<UserModel, User>().ForMember(a => a.UserDebits, b => b.MapFrom(c => c.UserDebits)).ReverseMap();
            CreateMap<DebitModel, Debit>().ForMember(a => a.Product, b => b.MapFrom(c => c.Product));
            
        }
    }
}
