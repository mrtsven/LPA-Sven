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
        WorkRepo workRepo;
        public PartijController()
        {
            workRepo = new WorkRepo(new Connection());
        }
        public List<Partij> getPartij()
        {
            return workRepo.getPartij();
        }

        public void createPartij(string naam, string lijsttrekker)
        {
            workRepo.createPartij(naam, lijsttrekker);
        }
        public void deletePartij(string naam)
        {
            workRepo.deletePartij(naam);
        }
    }
}
