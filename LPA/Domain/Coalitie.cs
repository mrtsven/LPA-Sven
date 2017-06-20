using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Domain
{
    public class Coalitie
    {
        public int id { get; set; }
        public List<Partij> formatie { get; set; }
        public string premier { get; set; }
    }
}
