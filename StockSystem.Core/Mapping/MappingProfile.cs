using AutoMapper;
using StockSystem.Entities.DTOs;
using StockSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Core.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductCreateDTO, Product>();
            CreateMap<Product, ProductCreateDTO>();

            CreateMap<MovementCreateDTO, Movement>();
            CreateMap<Movement, MovementCreateDTO>();
        }
    }
}
