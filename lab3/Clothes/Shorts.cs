using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Clothes
{
    [Serializable]
    public class Shorts : Pants
    {
        public Shorts(String name) : base(name) { }

        public Shorts() { }

        public override string ToString()
        {
            return "Shorts";
        }
    }
}
