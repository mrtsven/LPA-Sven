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
        IUitslagRepo uitslagRepo;
        public UitslagController()
        {
            uitslagRepo = new UitslagRepo(new Connection());
        }

        public void createUitslag(string uitslagNaam, string datum)
        {
            uitslagRepo.createUitslag(uitslagNaam, datum);
        }

        public List<Uitslag> getUitslag()
        {
            return uitslagRepo.getUitslag();
        }

        public void voegStemmenIn(int idPartij, int stemmen, string uitslagNaam)
        {
            uitslagRepo.voegStemmenIn(idPartij, stemmen, uitslagNaam);
        }
    }

}
