﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication_t
{
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
            bindgrid();
        }
        private void bindgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            banking_dbEntities6 bs= new banking_dbEntities6();
            var item =bs.userAccounts.ToList();
            dataGridView1.DataSource = item;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerList_Load(object sender, EventArgs e)
        {

        }
    }
}
