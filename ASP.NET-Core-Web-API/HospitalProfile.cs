using ASP.NET_Core_Web_API.Entities;
using ASP.NET_Core_Web_API.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API
{
    public class HospitalProfile : Profile
    {
        public HospitalProfile()
        {
            CreateMap<Operation, HospitalDetailsDto>()
                .ForMember(m => m.Country, map => map.MapFrom(operation => operation.HospitalWard.Country))
                .ForMember(m => m.Region, map => map.MapFrom(operation => operation.HospitalWard.Region));

        }
    }
}
