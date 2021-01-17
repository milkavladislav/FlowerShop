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
    public partial class FormSweet : Form
    {
        public FormSweet()
        {
            InitializeComponent();
        }

        private void buttonEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCookie_Click(object sender, EventArgs e)
        {
            FormCookie formCookie = new FormCookie();
            formCookie.Owner = this;
            formCookie.Show();
        }

        private void buttonCandy_Click(object sender, EventArgs e)
        {
            FormCandy formCandy = new FormCandy();
            formCandy.Owner = this;
            formCandy.Show();
        }
    }
}
