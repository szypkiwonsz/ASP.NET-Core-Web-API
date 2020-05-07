using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Models
{
    public class HospitalDetailsDto
    {
        public string OperationName { get; set; }
        public string Doctor { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
    }
}
