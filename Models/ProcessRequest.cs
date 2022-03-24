using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentProcessingMS.Models
{
    public class ProcessRequest
    { 
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string CreditCardNumber { get; set; }
        public string ComponentType { get; set; }
        public string ComponentName { get; set; }
        public double Quantity { get; set; }
        public bool IsPriorityRequest { get; set; }

        public string CreditLimit { get; set;}
    }
}
