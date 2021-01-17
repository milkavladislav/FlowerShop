using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class Order
    {
        private const double _defaultTotalPrice = 0;
        private double totalPrice;
        public double TotalPrice
        {
            get
            {
                totalPrice = _defaultTotalPrice;
                foreach (IGoods goods in ListGoods)
                {
                    totalPrice += goods.Price;
                }
                return totalPrice;
            }
        }

        public List<IGoods> ListGoods = new List<IGoods>();
        public User Customer { get; set; }

        private DateTime dateTime;

        public Order(List<IGoods> listGoods, User user)
        {
            ListGoods = listGoods;
            Customer = user;
            dateTime = DateTime.Now;
        }

        public Order(User user) : this(new List<IGoods>(), user)
        { }

        public override string ToString()
        {
            string descriptionOrder = "";
            foreach (IGoods goods in ListGoods)
            {
                descriptionOrder += goods.Name +
                 "  --   " + goods.Price + ";\n";
            }
            return descriptionOrder;
        } 

        public string FormDescription()
        {
            string descriptionOrder = Customer.ToString();

            foreach (IGoods goods in ListGoods)
            {
                goods.FormDescription();
                descriptionOrder += "\nName: " + goods.Name + 
                  "\nDesciption: " + goods.Description +
                 "\nPrice: " + goods.Price + ";\n";
            }

            descriptionOrder += "Order date and time: " + dateTime;

            return descriptionOrder;
        }
    }
}
