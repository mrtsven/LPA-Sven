using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Domain
{
    public class Partij
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string lijsttrekker { get; set; }
        public int zetels { get; set; }
        public int stemmers { get; set; }

        public override string ToString()
        {
            return naam;
        }
    }

}
