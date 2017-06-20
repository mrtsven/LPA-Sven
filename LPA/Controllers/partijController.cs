using LPA.Domain;
using LPA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Controllers
{
    public class PartijController
    {
        PartijRepo partijRepo;
        public PartijController()
        {
            partijRepo = new PartijRepo(new Connection());
        }
        public List<Partij> getPartij()
        {
            return partijRepo.getPartij();
        }
    }
}
