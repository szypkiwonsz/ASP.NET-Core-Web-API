using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Entities
{
    public class Atrakcja
    {
        public int Id { get; set; }
        public string NazwaAtrakcji { get; set; }
        public int Odleglosc { get; set; }
        public int Cena { get; set; }
        public string Opis { get; set; }
        public virtual Wyjazd Wyjazd { get; set; }
        public virtual int WyjazdId { get; set; }
    }
}
