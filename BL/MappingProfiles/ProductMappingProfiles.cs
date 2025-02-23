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
    public  class ProductMappingProfiles:Profile
    {
        public ProductMappingProfiles() 
        {
            CreateMap<ProductModel, Product>().ReverseMap();
            CreateMap<WareHouseModel, WareHouse>().ReverseMap();
        }
    }
}
