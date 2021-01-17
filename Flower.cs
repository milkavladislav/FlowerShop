using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class Flower
    {
        private const double _defaultPrice = 9;

        public int Height { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public double Price { get; set; }

        public Flower(int height, string color, string type) : this(height, color, type, _defaultPrice)
        { }
        public Flower(int height, string color, string type, double price)
        {
            Height = height;
            Color = color;
            Type = type;
            Price = price;
        }


        public override string ToString()
        {
            return "height = " + Height + "; color = " + Color + "; type = " + Type + "; ";
        }
    }
}
