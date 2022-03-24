using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentProcessingMS.Models;

namespace ComponentProcessingMS.Repositorys
{
    public class RequestDatabase
    {
        public List<DatabaseModel> Master = new List<DatabaseModel>()
        {
            new DatabaseModel(){ComponenType="Integral", PriorReqCharge=200 , ProcessingCh=500, PriorDelverivery=DateTime.Today.AddDays(2), NormalDelivery = DateTime.Today.AddDays(5) },
            new DatabaseModel(){ComponenType="Accessory", ProcessingCh=300, PriorReqCharge=200, PriorDelverivery=DateTime.Today.AddDays(2), NormalDelivery = DateTime.Today.AddDays(5)}
        };

         
    }
}
