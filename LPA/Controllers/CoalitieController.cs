using LPA.Domain;
using LPA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Controllers
{
    public class CoalitieController
    {
        ICoalitieRepo workRepo;
        public CoalitieController()
        {
            workRepo = new CoalitieRepo(new Connection());
        }

        public void createCoalitie(List<Coalitie> coalitie)
        {
            workRepo.createCoalitie(coalitie);
        }

        public List<Coalitie> getCoalitie()
        {
            return workRepo.getCoalitie();
        }
    }
}
