using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPA.Domain;

namespace LPA.Repositories
{
    public class CoalitieRepo : ICoalitieRepo
    {
        IConnection connection;
        public CoalitieRepo(IConnection connection)
        {
            this.connection = connection;
        }

        public void createCoalitie(List<Coalitie> coalitieLijst)
        {
            throw new NotImplementedException();
        }

        public List<Coalitie> getCoalitie()
        {
            throw new NotImplementedException();
        }
    }
}
