using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPA.Domain;

namespace LPA.Repositories
{
    public class UitslagRepo : IUitslagRepo
    {
        IConnection connection;
        public UitslagRepo(IConnection connection)
        {
            this.connection = connection;
        }

        public void createUitslag(List<Partij> partijen, int stemmers, int zetels)
        {
            throw new NotImplementedException();
        }

        public List<Uitslag> getUitslag()
        {
            throw new NotImplementedException();
        }
    }
}
