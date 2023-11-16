using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    public class Cube
    {
        public int test { get; set; }
        public int test2 { get; set; }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Cube p = (Cube)obj;
                return (test == p.test) && (test2 == p.test2);
            }
        }
    }
}
