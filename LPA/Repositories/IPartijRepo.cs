using LPA.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Repositories
{
    public interface IPartijRepo
    {
        List<Partij> getPartijMet(int uitslagID);
        List<Partij> getPartij();
        void createPartij(string naam, string lijsttrekker);
        void deletePartij(string naam);
        void updatePartij(string naam, string nieuwenaam, string nieuwelijsttrekker);
    }
}
