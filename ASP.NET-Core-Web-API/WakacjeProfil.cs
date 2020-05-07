using ASP.NET_Core_Web_API.Entities;
using ASP.NET_Core_Web_API.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API
{
    public class WakacjeProfile : Profile
    {
        public WakacjeProfile()
        {
            CreateMap<Wyjazd, WakacjeDetailsDto>()
                .ForMember(m => m.Kraj, map => map.MapFrom(wyjazd => wyjazd.Miejsce.Kraj))
                .ForMember(m => m.Region, map => map.MapFrom(wyjazd => wyjazd.Miejsce.Region));

        }
    }
}
