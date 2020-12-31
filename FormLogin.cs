using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.txtUserId.Text=="salim" && this.txtPassword.Text=="1234")
            {
                MessageBox.Show("Login Successfull");
                this.txtPassword.Text = "";
                this.txtUserId.Text = "";
                new FormAdminHome().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
