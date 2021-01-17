using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class FormBucket : Form
    {
        public FormBucket()
        {
            InitializeComponent();
        }

        private Bucket bucket = new Bucket();

        private void buttonAddFlower_Click(object sender, EventArgs e)
        {
            string color = listFlowerColor.Text;
            string type = listFlowerType.Text;
            string size = listFlowerHeight.Text;
            int count = Convert.ToInt32(flowerCount.Value);

            Flower flower = new Flower(int.Parse(size), color, type);
            for(int i = 0; i < count; i++)
            {
                bucket.AddFlower(flower);
            }

            UpdateTable();
        }

        private void buttonAddWrapper_Click(object sender, EventArgs e)
        {
            string color = listWrapperColor.Text;
            string type = listWrapperType.Text;

            Wrapper wrap = new Wrapper(color, type);

            bucket.Wrap = wrap;

            UpdateTable();
        }

        private void UpdateTable()
        {
            bucket.FormDescription();
            formFlower.Text = bucket.Description;
            labelFlowerCount.Text = Convert.ToString(bucket.FlowerCount);
            UpdatePrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bucket.Name = bucketName.Text;

            FormOrder main = this.Owner as FormOrder;

            main.order.ListGoods.Add(bucket);
            main.labelOrder.Text = main.order.ToString();
            main.labelTotalPrice.Text = Convert.ToString(main.order.TotalPrice);
            this.Close();
        }

        private void UpdatePrice()
        {
            labelPrice.Text = Convert.ToString(bucket.Price);
        }
    }
}