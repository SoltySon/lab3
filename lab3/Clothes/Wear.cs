using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Clothes
{
    [Serializable]
    public abstract class Wear
    {
        public string name { get; set; }
        public string color { get; set; }
        public string material { get; set; }
        public TypeOfWear typeOfWear { get; set; }

        public Wear() { }

        public Wear(String name)
        {
            this.name = name;
        }
    }


    public enum TypeOfWear : int
    {
        Outerwear,
        Underwear
    }
}
