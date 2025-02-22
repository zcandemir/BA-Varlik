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
    public class DebitMappingProfiles: Profile
    {

        public DebitMappingProfiles()
        {
            CreateMap<DebitModel, Debit>();

            CreateMap<DebitModel, Debit>().ForMember(a => a.AssignedUser, b => b.MapFrom(c => c.AssignedUser)).ReverseMap();

            CreateMap<DebitModel, Debit>().ForMember(a => a.AssigningUser, b => b.MapFrom(c => c.AssigningUser)).ReverseMap();




        }   

    }
}
