using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentProcessingMS.Repositorys;
using ComponentProcessingMS.Models;

namespace ComponentProcessingMS.Services
{
    public class ComponentServ : IComponentServ
    {
        private readonly IComponentRepo _componentRepo;

        public ComponentServ(IComponentRepo componentRepo)
        {
            _componentRepo = componentRepo;
        }

        public ProcessResponse GetProcessResponse(ProcessRequest req)
        {
            return _componentRepo.GetProcessRequestRepo(req);
        }

        public string CompleteProcess()
        {
            return _componentRepo.CompleteProcess();
        }



    }
}
