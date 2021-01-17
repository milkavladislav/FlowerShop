using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class Bucket : IGoods
    {
        private const double _defaultPrice = 0;
        private const int _defaultFlowerCount = 0;
        public string Description { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        public int FlowerCount { get; private set; }

        private List<Flower> Flowers = new List<Flower>();

        public Wrapper Wrap = new Wrapper();

        public Bucket(string description, double price, string name, List<Flower> flowers, Wrapper wrap, int flowerCount)
        {
            Description = description;
            Price = price;
            Name = name;
            Flowers = flowers;
            Wrap = wrap;
        }

        public Bucket() : this ("", _defaultPrice, "bucket", new List<Flower>(), new Wrapper(), _defaultFlowerCount) 
        { }

        public void FormDescription()
        {
            Price = 0;
            Description = "Flowers:\n";
            foreach (Flower flower in Flowers)
            {
                Description += flower.ToString() + "\n";
                Price += flower.Price;
            }
            Description += "Wrapper: \n";
            Description += Wrap.ToString();
            Price += Wrap.Price;
        }

        public void AddFlower(Flower flower)
        {
            Flowers.Add(flower);
            FlowerCount++;
        }
    }
}
