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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        public Order order = new Order(new User());

        private void buttonBucket_Click(object sender, EventArgs e)
        {
            FormBucket BucketForm = new FormBucket();
            BucketForm.Owner = this;
            BucketForm.Show();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            this.Text = this.Name;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormVarification main = this.Owner as FormVarification;
            main.Show();
            main.textNickName.Text = "";
            main.textPassword.Text = "";
            this.Close();
        }

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            Json.PostInJson(order);
            MessageBox.Show("Your order add");
        }

        private void buttonSweet_Click(object sender, EventArgs e)
        {
            FormSweet formSweet = new FormSweet();
            formSweet.Owner = this;
            formSweet.Show();
        }
    }
}
