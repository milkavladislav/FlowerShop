using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Candy : Sweet
    {
        private const bool _defaultIsChocolate = true;
        private const string _defaultType = "ordinary";
        public string Type { get; set; }

        public bool IsChocolate { get; set; }

        public Candy()
        {
            IsChocolate = _defaultIsChocolate;
            Type = _defaultType;
        }
        public override void FormDescription()
        {
            Description = "calorieContent = " + CalorieContent +
                "; Have chokolate: " + IsChocolate +
                "; type: " + Type + 
            "; weight = " + Weight + ";\n";
        }

    }
}
