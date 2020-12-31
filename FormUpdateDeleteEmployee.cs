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
    public partial class FormUpdateDeleteEmployee : Form
    {
        private string Gender;
        public FormUpdateDeleteEmployee()
        {
            InitializeComponent();
            this.PopulateDataGridView();
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

        public void PopulateDataGridView()
        {
            this.dgvEmployee.DataSource = DataAccess.ExecuteQuery("select * from employee");
        }

        private void FormUpdateDeleteEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSupdate_Click(object sender, EventArgs e)
        {
            if(this.dgvEmployee.SelectedRows.Count!=1)
            {
                MessageBox.Show("Please Select a employee");
            }
            else
            {
                this.txtName.Text = this.dgvEmployee.CurrentRow.Cells["name"].Value.ToString();
                this.txtEmail.Text = this.dgvEmployee.CurrentRow.Cells["email"].Value.ToString();
                this.cbBlood.Text = this.dgvEmployee.CurrentRow.Cells["bloodgroup"].Value.ToString();

                
                /*if (rbMale.Checked)
                    Gender = "Male";
                else if (rbFemale.Checked)
                    Gender = "Female";
                */
               // this.txtGender.Text = this.dgvEmployee.CurrentRow.Cells["gender"].Value.ToString();
                this.cbJobType.Text = this.dgvEmployee.CurrentRow.Cells["jobtype"].Value.ToString();
               //this.dtpDob.Text = this.dgvEmployee.CurrentRow.Cells["dateofbirth"].Value.ToString();
                this.txtSalary.Text = this.dgvEmployee.CurrentRow.Cells["salary"].Value.ToString();
                this.txtId.Text = this.dgvEmployee.CurrentRow.Cells["id"].Value.ToString();

                //this.email.HeaderText=
            }
        }

        private void FormUpdateDeleteEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update employee set name='"+this.txtName.Text+"',email='"+this.txtEmail.Text+"',bloodgroup='"+this.cbBlood.Text+"',jobtype='"+this.cbJobType.Text+"',salary='"+this.txtSalary.Text+"' where id='"+this.txtId.Text+"'";
            MessageBox.Show(sql);
            if (DataAccess.ExecuteUpdate(sql) == 1)
            {
                MessageBox.Show("Update Successful");
                this.PopulateDataGridView();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.dgvEmployee.SelectedRows.Count!=1)
            {
                MessageBox.Show("please Select a employee");
            }
            else
            {
                string sql="delete from employee where id='"+ this.dgvEmployee.CurrentRow.Cells["id"].Value.ToString() +"'";
                if(DataAccess.ExecuteUpdate(sql)==1)
                {
                    MessageBox.Show("Delete Successful");
                    this.PopulateDataGridView();

                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAdminHome().Show();
        }
    }
}
