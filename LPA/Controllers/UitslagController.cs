using LPA.Domain;
using LPA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Controllers
{
    public class UitslagController
    {
        WorkRepo workRepo;
        public UitslagController()
        {
            workRepo = new WorkRepo(new Connection());
        }

        public void createUitslag(List<Partij> partijen, int stemmers, int zetels)
        {
            workRepo.createUitslag(partijen, stemmers, zetels);
        }

        public List<Uitslag> getUitslag()
        {
            return workRepo.getUitslag();
        }
    }
}
