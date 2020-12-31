using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagementSystem.DB;

namespace RestaurantManagementSystem
{
    public partial class FormShowEmployee : Form
    {
        public FormShowEmployee()
        {
            InitializeComponent();
            PopulateDataGridView();
        }
        public void PopulateDataGridView(string sql="")
        {
            if(sql=="")
            this.dgvEmployee.DataSource = DataAccess.ExecuteQuery("select * from employee");
            else
                this.dgvEmployee.DataSource = DataAccess.ExecuteQuery(sql);
        }

        private void FormShowEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(this.txtSearch.Text!="")
            {
                string sql = "select * from employee where id='"+this.txtSearch.Text+"'";
                this.PopulateDataGridView(sql);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAdminHome().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
            this.PopulateDataGridView();
        }
    }
}
