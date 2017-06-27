using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Clothes
{
    [Serializable]
    public class Pants : Wear
    {
        public string waist { get; set; }
        public string length { get; set; }

        public Pants(String name) : base(name) { }

        public Pants() { }

        public override string ToString()
        {
            return "Pants";
        }
    }
}
