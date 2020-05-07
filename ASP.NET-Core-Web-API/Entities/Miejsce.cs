using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Entities
{
    public class Miejsce
    {
        public int Id { get; set; }
        public string Kraj { get; set; }
        public string Region { get; set; }
        public virtual Wyjazd Wyjazd { get; set; }
        public virtual int WyjazdId { get; set; }
    }
}
