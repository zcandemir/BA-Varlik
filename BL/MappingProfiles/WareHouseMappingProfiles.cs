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
    public class WareHouseMappingProfiles : Profile
    {
        public WareHouseMappingProfiles()
        {
            CreateMap<WareHouseModel, WareHouse>().ReverseMap();
        }
    }
}
