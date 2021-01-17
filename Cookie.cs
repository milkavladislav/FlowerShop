using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Cookie : Sweet
    {
        private const string _defoultTypeDough = "ordinary";
        public string TypeDough { get; set; } = _defoultTypeDough;
        public override void FormDescription()
        {
            Description = "calorieContent = " + CalorieContent +
                "\nType of dough: " + _defoultTypeDough +
            "; weight = " + Weight + ";\n";
        }
    }
}
