using ASP.NET_Core_Web_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API
{
    public class AddHospital
    {
        private HospitalContext hospitalContext;

        public AddHospital(HospitalContext hospitalContext) 
        { 
            this.hospitalContext = hospitalContext; 
        }

        public void AddData() 
        { 
            if (hospitalContext.Database.CanConnect()) 
            { 
                if (!hospitalContext.Operations.Any()) 
                { 
                    InsertRecords(); 
                } 
            } 
        }

        private void InsertRecords()
        {
            var operations = new List<Operation>    
                {     
                    new Operation {
                        OperationName = "Appendectomy",
                        Doctor = "Max Schmidt",
                        Date = DateTime.Now.AddDays(10),
                        HospitalWard = new HospitalWard
                        {
                            Country = "Poland",
                            Region = "Pomeranian Voivodeship",
                        },
                        MedicalProcedures = new List<MedicalProcedure>  
                        {
                            new MedicalProcedure {        
                                MedicalProcedureName = "Treatment",
                                Price = 40,
                                Description = "Simple medical procedure"       
                            }

                        }

                    },     

            }; hospitalContext.AddRange(operations); hospitalContext.SaveChanges();
        }
    }
}