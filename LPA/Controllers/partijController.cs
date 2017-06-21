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
        IPartijRepo partijRepo;
        public PartijController()
        {
            partijRepo = new PartijRepo(new Connection());
        }
        public List<Partij> getPartijMet(int uitslagID)
        {
            return partijRepo.getPartijMet(uitslagID);
        }

        public List<Partij> getPartij()
        {
            return partijRepo.getPartij();
        }

        public void createPartij(string naam, string lijsttrekker)
        {
            partijRepo.createPartij(naam, lijsttrekker);
        }
        public void deletePartij(string naam)
        {
            partijRepo.deletePartij(naam);
        }

        public void updatePartij(string naam, string nieuwenaam, string nieuwelijsttrekker)
        {
            partijRepo.updatePartij(naam, nieuwenaam, nieuwelijsttrekker);
        }
    }
}
