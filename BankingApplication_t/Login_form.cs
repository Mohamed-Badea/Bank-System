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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities6 dbe = new banking_dbEntities6();
            if (usrtxt.Text!=string.Empty || passtxt.Text!=string.Empty)
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usrtxt.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(passtxt.Text))
                    {
                        Menu m1 = new Menu();
                        m1.ShowDialog();
                      
                    }
                    else
                    {
                       MessageBox.Show("password incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("no username");

                }
            }
            else
            {
                MessageBox.Show("please enter username and password");

            }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
