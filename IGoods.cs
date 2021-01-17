using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public interface IGoods
    {
        string Name { get; set; }
        string Description { get; set; }

        double Price { get;}

        void FormDescription();
    }
}
