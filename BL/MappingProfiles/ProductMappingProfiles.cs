using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.MappingProfiles;
using BL.Models;
using DAL.Entities;

namespace BL.MappingProfiles
{
    public  class ProductMappingProfiles :Profile
    {
        
        ProductMappingProfiles() 
        {
            CreateMap<ProductModel, Product>().ForMember(a => a.WareHouse, b => b.MapFrom(c => c.WareHouse)).ReverseMap();
        }


    }
}


