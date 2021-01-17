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
    public partial class FormVarification : Form
    {
        User user = new User();
        public FormVarification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textPassword.Text;
            string nickname = textNickName.Text;

            if(user.IsPasswordCorrect(nickname, password))
            {
                this.Hide();
                FormOrder formOrder = new FormOrder();
                formOrder.Owner = this;
                formOrder.order.Customer = user;
                formOrder.Name = user.Name + ";   Access type: " + user.AccessType;
                formOrder.Show();
                if(user.AccessType == "Manager")
                {
                    FormDisplayOrder formDisplayOrder = new FormDisplayOrder();
                    formDisplayOrder.Show();
                }
            }
            else
            {
                MessageBox.Show("User is not found", "Error");
            }
        }
    }
}
