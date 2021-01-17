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
    public partial class FormCandy : Form
    {
        public FormCandy()
        {
            InitializeComponent();
        }

        private Candy candy = new Candy();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSweet formSweet = this.Owner as FormSweet;

            FormOrder main = formSweet.Owner as FormOrder;

            candy.Name = listCandy.Text;
            candy.Weight = (double)weight.Value;

            main.order.ListGoods.Add(candy);
            main.labelOrder.Text = main.order.ToString();
            main.labelTotalPrice.Text = Convert.ToString(main.order.TotalPrice);
            this.Close();
            formSweet.Close();
        }
    }
}
