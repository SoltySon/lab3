using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Clothes
{
    [Serializable]
    public class Shirt : Jacket
    {
        public Shirt(String name) : base(name) { }

        public Shirt() { }

        public override string ToString()
        {
            return "Shirt";
        }
    }
}
