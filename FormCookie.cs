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
    public partial class FormCookie : Form
    {
        public FormCookie()
        {
            InitializeComponent();
        }

        private Cookie cookie = new Cookie();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSweet formSweet = this.Owner as FormSweet;

            FormOrder main = formSweet.Owner as FormOrder;

            cookie.Name = listCookie.Text;
            cookie.Weight = (double)weight.Value;

            main.order.ListGoods.Add(cookie);
            main.labelOrder.Text = main.order.ToString();
            main.labelTotalPrice.Text = Convert.ToString(main.order.TotalPrice);
            this.Close();
            formSweet.Close();
        }
    }
}
