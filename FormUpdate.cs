﻿using System;
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
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
            this.PopulateDataGridView();
        }
        public void PopulateDataGridView()
        {
            this.dataGridView1.DataSource = DataAccess.ExecuteQuery("select * from employee");
        }
    }
}
