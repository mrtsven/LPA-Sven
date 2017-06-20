using LPA.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Repositories
{
    public interface IWorkRepo
    {
        List<Partij> getPartij();
        void createPartij(string naam, string lijsttrekker);
        void deletePartij(string naam);
        void createCoalitie(List<Coalitie> coalitieLijst);
        List<Coalitie> getCoalitie();
        void createUitslag(List<Partij> partijen, int stemmers, int zetels);
        List<Uitslag> getUitslag();
    }
}
