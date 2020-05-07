using ASP.NET_Core_Web_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API
{
    public class DodajWakacje
    {
        private WakacjeContext wakacjeContext;

        public DodajWakacje(WakacjeContext wakacjeContext) { this.wakacjeContext = wakacjeContext; }

        public void DodajDane() 
        { 
            if (wakacjeContext.Database.CanConnect()) 
            { 
                if (!wakacjeContext.Wyjazdy.Any()) 
                { 
                    WstawRekordy(); 
                } 
            } 
        }

        private void WstawRekordy()
        {
            var wyjazdy = new List<Wyjazd>    
                {     
                    new Wyjazd {
                        NazwaWyjazdu = "integracja",
                        Organizator = "Microsoft",
                        Data = DateTime.Now.AddDays(10),
                        CzyFirma = true,
                        Miejsce = new Miejsce
                        {
                            Kraj = "Polska",
                            Region = "Kaszuby",
                        },
                        Atrakcje = new List<Atrakcja>  
                        {
                            new Atrakcja {        
                                NazwaAtrakcji = "Basen",
                                Odleglosc = 20,
                                Cena = 40,
                                Opis = "kilka wyjazdów na basen w trakcie pobytu"       
                            }

                        }

                    },     
                    new Wyjazd     
                    {      
                        NazwaWyjazdu = "wakacje na mazurach",
                        Organizator = "biuro mazurex",
                        Data = DateTime.Now.AddDays(32),
                        CzyFirma = false,
                        Miejsce = new Miejsce
                        {
                            Kraj = "Polska",
                            Region = "Mazury",
                        },      
                        Atrakcje = new List<Atrakcja>
                        {
                            new Atrakcja {
                                NazwaAtrakcji = "Żagle",
                                Odleglosc = 0,
                                Cena = 50,
                                Opis = "nauka pływania na żaglówkach"
                            },
                            new Atrakcja {
                                NazwaAtrakcji = "Ognisko",
                                Odleglosc = 3,
                                Cena = 10,
                                Opis = "wspólne ognisko w lesie"
                            }
                        }     
                    }

            }; wakacjeContext.AddRange(wyjazdy); wakacjeContext.SaveChanges();
        }
    }
}