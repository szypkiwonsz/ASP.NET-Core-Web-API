using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Entities
{
    public class Wyjazd
    {
        public int Id { get; set; }
        public string NazwaWyjazdu { get; set; }
        public string Organizator { get; set; }
        public DateTime Data { get; set; }
        public bool CzyFirma { get; set; }

        public virtual Miejsce Miejsce { get; set; }

        public virtual List<Atrakcja> Atrakcje { get; set; }
    }
}
