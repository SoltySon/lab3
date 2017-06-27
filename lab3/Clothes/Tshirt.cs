using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Clothes
{
    [Serializable]
    public class Tshirt : Jacket
    {
        public Tshirt(String name) : base(name) { }

        public Tshirt() { }

        public override string ToString()
        {
            return "Tshirt";
        }
    }
}
