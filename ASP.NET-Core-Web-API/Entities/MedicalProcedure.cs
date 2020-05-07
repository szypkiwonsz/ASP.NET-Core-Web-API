using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_API.Entities
{
    public class MedicalProcedure
    {
        public int Id { get; set; }
        public string MedicalProcedureName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual int OperationId { get; set; }
    }
}
