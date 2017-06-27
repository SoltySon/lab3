using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Clothes
{
    [Serializable]
    public class Dress : Wear
    {
        public string size { get; set; }
        public string chestGirth { get; set; }
        public string waist { get; set; }
        public string length { get; set; }

        public Dress(String name) : base(name) { }

        public Dress() { }

        public override string ToString()
        {
            return "Dress";
        }
    }
}
