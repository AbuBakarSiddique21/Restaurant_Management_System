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
    public partial class FormAdminHome : Form
    {
        public FormAdminHome()
        {
            InitializeComponent();
        }

        private void FormAdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddNewEmployee().Show();
        }

        private void btnShowEmpInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormShowEmployee a=new FormShowEmployee();
            a.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new FormUpdateDeleteEmployee().Show();
            this.Hide();
;           // this.Hide();
           //new FormUpdateDeleteEmployee().Show();
          // new FormUpdate().Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }
    }
}
