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
    public partial class AddNewEmployee : Form
    {
        public AddNewEmployee()
        {
            InitializeComponent();
            this.cbJobType.DataSource = new List<string>{
                "manager",
                    "admin",
                "waiter"
,
                    };
            this.cbBlood.DataSource = new List<string>
            {

                "A+",
                "A-",
                "AB+",
                "AB-",
                "B+",
                "B-",
                "O+",
                "O-",
            };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        internal void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPass1.Text = "";
            txtPass2.Text = "";
            txtSalary.Text = "";
            txtEmail.Text = "";
            cbBlood.Text = "O+";
            dtpDob.Text = "";
            dtpJoin.Text = "";
            cbJobType.Text = "admin";

        }

        private void AddNewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtPass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string date = dtpDob.Text.ToString();

            string date1 = dtpJoin.Text.ToString(); 
            string gender = "";
            if (this.rbMale.Checked)
                gender = "male";
            else
               // insert into employee values('salim','p','E','b','g','m','200','1','3')
                gender = "female";
            string sql = "insert into employee values('" + this.txtName.Text + "','" + this.txtPass1.Text + "','" + this.txtEmail.Text + "','" + this.cbBlood.Text + "','" + gender + "','" + this.cbJobType.Text + "','" +this.txtSalary.Text +"','" + date1 + "','" + date + "')";
            MessageBox.Show(sql);
            try
            {
                if (DataAccess.ExecuteUpdate(sql) == 1)
                {
                    MessageBox.Show("Employee added successfully");
                    this.Clear();

                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        
        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddNewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FormAdminHome().Show();
            this.Hide();
        }
    }
}
