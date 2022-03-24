using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentProcessingMS.Models;

namespace ComponentProcessingMS.Repositorys
{
    public interface IComponentRepo
    {
        public ProcessResponse GetProcessRequestRepo(ProcessRequest req);
        public string CompleteProcess();
    }
}
