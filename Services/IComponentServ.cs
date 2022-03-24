using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentProcessingMS.Models;

namespace ComponentProcessingMS.Services
{
   public interface IComponentServ
    {
        public ProcessResponse GetProcessResponse(ProcessRequest req);
        public string CompleteProcess();
    }
  
}
