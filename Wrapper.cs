using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class Wrapper
    {
        private const double _defaultPrice = 10;
        private const string _defaultColor = "white";
        private const string _defaultType = "ordinary";

        public string Color { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }

        public Wrapper(string color, double price, string type)
        {
            Color = color;
            Price = price;
            Type = type;
        }

        public Wrapper(string color, string type) : this(color, _defaultPrice, type)
        { }

        public Wrapper() : this(_defaultColor, _defaultPrice, _defaultType)
        { }


        public override string ToString()
        {
            return "color = " + Color + "; type = " + Type + "; ";
        }

    }
}
