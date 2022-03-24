using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentProcessingMS.Models;

namespace ComponentProcessingMS
{
    public class RequestDataHelper
    {
        public static ProcessRequest requestObject = new ProcessRequest()
        {

            ComponentName = "Dress",
            Name = "Aby",
            ComponentType = "Integral",
            ContactNumber = "564578963",
            CreditCardNumber = "454244555456644",
            CreditLimit = "1000",
            IsPriorityRequest = false,
            Quantity = 1
        };

        public static ProcessResponse responseObj = new ProcessResponse()
        {

        };
    }
}
