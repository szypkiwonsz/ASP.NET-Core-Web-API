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
    [Route("api/operation")]
    public class HospitalController : ControllerBase
    {
        private HospitalContext hospital;
        private IMapper mapper;

        public HospitalController(HospitalContext hospital, IMapper mapper) 
        { 
            this.hospital = hospital;
            this.mapper = mapper;
        }

        public ActionResult<List<HospitalDetailsDto>> Get()
        {
            var operations = hospital.Operations.Include(m => m.HospitalWard).ToList();
            var operationsDto = mapper.Map<List<HospitalDetailsDto>>(operations);

            return Ok(operationsDto);
        }

        [HttpGet("{name}")]
        public ActionResult<List<HospitalDetailsDto>> Get(string name)
        {
            var operation = hospital.Operations.Include(m => m.HospitalWard).FirstOrDefault(operation => operation.OperationName.Replace(" ", "-").ToLower() == name.ToLower());

            if (operation == null) { return NotFound(); }
            else
            {
                var operationDto = mapper.Map<HospitalDetailsDto>(operation); return Ok(operationDto);
            }
        }
    }
}
