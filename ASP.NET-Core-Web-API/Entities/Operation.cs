using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Entities
{
    public class Operation
    {
        public int Id { get; set; }
        public string OperationName { get; set; }
        public string Doctor { get; set; }
        public DateTime Date { get; set; }

        public virtual HospitalWard HospitalWard { get; set; }

        public virtual List<MedicalProcedure> MedicalProcedures { get; set; }
    }
}
