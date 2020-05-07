using ASP.NET_Core_Web_API.Entities;
using ASP.NET_Core_Web_API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Controllers
{
    [Route("api/wyjazd")]
    public class WakacjeController : ControllerBase
    {
        private WakacjeContext wakacje;
        private IMapper mapper;

        public WakacjeController(WakacjeContext wakacje, IMapper mapper) 
        { 
            this.wakacje = wakacje;
            this.mapper = mapper;
        }

        public ActionResult<List<WakacjeDetailsDto>> Get()
        {
            var wyjazdy = wakacje.Wyjazdy.Include(m => m.Miejsce).ToList();
            var wyjazdyDto = mapper.Map<List<WakacjeDetailsDto>>(wyjazdy);

            return Ok(wyjazdyDto);
        }

        [HttpGet("{name}")]
        public ActionResult<List<WakacjeDetailsDto>> Get(string name)
        {
            var wyjazd = wakacje.Wyjazdy.Include(m => m.Miejsce).FirstOrDefault(wyjazd => wyjazd.NazwaWyjazdu.Replace(" ", "-").ToLower() == name.ToLower());

            if (wyjazd == null) { return NotFound(); }
            else
            {
                var wyjazdDto = mapper.Map<WakacjeDetailsDto>(wyjazd); return Ok(wyjazdDto);
            }
        }
    }
}
