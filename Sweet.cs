using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    abstract class Sweet : IGoods
    {
        private const double _defaultCalorieContent = 300;
        private const double _defaultPrice = 1000;
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price
        {
            get
            {
                return _defaultPrice * Weight / 100;
            }
        }


        public double Weight { get; set; }

        private double calorieContent;
        public double CalorieContent
        {
            get
            {
                return calorieContent * (Weight / 100);
            }
            private set
            {
                calorieContent = _defaultCalorieContent;
            }
        }

        public abstract void FormDescription();
    }
}
