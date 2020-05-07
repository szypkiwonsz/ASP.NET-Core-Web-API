using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Entities
{
    public class HospitalWard
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual int OperationId { get; set; }
    }
}
