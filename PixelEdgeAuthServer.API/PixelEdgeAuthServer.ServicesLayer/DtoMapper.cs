using AutoMapper;
using PixelEdgeAuthServer.CoreLayer.DTOs;
using PixelEdgeAuthServer.CoreLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.ServicesLayer
{
    internal class DtoMapper:Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<AppUserDto, AppUser>().ReverseMap();
        }

    }
}
