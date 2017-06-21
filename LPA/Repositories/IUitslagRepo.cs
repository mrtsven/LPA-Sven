using LPA.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Repositories
{
    public interface IUitslagRepo
    {
        //, int IDPartij, int stemmen
        void createUitslag(string uitslagNaam, string datum);
        void voegStemmenIn(int idPartij, int stemmen, string uitslagNaam);

        List<Uitslag> getUitslag();
    }
}
