using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Clothes
{
    [Serializable]
    public class Jacket : Wear
    {
        public string size { get; set; }
        public string growth { get; set; }
        public string chestGirth { get; set; }

        public Jacket(String name) : base(name) { }

        public Jacket() { }

        public override string ToString()
        {
            return "Jacket";
        }
    }
}
