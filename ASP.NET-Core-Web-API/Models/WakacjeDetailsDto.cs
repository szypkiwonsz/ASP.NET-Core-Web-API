using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Models
{
    public class WakacjeDetailsDto
    {
        public string NazwaWyjazdu { get; set; }
        public string Organizator { get; set; }
        public DateTime Data { get; set; }
        public bool CzyFirma { get; set; }
        public string Kraj { get; set; }
        public string Region { get; set; }
    }
}
