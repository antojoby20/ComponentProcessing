using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentProcessingMS.Models
{
    public class DatabaseModel
    {
        public int ProcessingCh { get; set; }

        public double PriorReqCharge { get; set; }

        public string ComponenType { get; set; }

        public bool Priorreq { get; set; }

        public DateTime PriorDelverivery { get; set; }

        public DateTime NormalDelivery { get; set; }
    }
}
