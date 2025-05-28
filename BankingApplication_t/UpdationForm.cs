using System;
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
    public partial class UpdationForm : Form
    {
        banking_dbEntities6 dbe;
        BindingList<userAccount> bi;
        public UpdationForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bi=new BindingList<userAccount>();  
            dbe= new banking_dbEntities6();
            if(acctxt.Text == string.Empty)
            {
                MessageBox.Show("username is empty");
            }
            else
            {
                decimal accno = Convert.ToDecimal(acctxt.Text);
                var item = dbe.userAccounts.Where(a => a.Account_No == accno);
                foreach (var item1 in item)
                {
                    bi.Add(item1);

                }
                dataGridView1.DataSource = bi;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities6();
            var item = dbe.userAccounts.Where(a => a.Name == nametxt.Text);
            foreach (var item1 in item)
            {
                bi.Add(item1);

            }
            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new banking_dbEntities6();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno).FirstOrDefault();
            acctxt.Text = item.Account_No.ToString();
            phonetxt.Text = item.PhoneNo;
            addresstxt.Text = item.Address;
            if(item.Gender=="male")
            {
                maleradio.Checked = true;
            }
            else if (item.Gender == "female")
            {
                femaleradio.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // bi.RemoveAt(dataGridView1.SelectedRows[0].Index);
            bi.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            dbe = new banking_dbEntities6();
            decimal a = Convert.ToDecimal(acctxt.Text);
            userAccount acc = dbe.userAccounts.First(s => s.Account_No.Equals(a));
            dbe.userAccounts.Remove(acc);
            dbe.SaveChanges();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbe = new banking_dbEntities6();
            decimal accountno = Convert.ToDecimal(acctxt.Text);
            userAccount useraccount = dbe.userAccounts.First(s => s.Account_No.Equals(accountno));
            useraccount.Account_No = Convert.ToDecimal(acctxt.Text);
            useraccount.Name = nametxt.Text;
            useraccount.Date = dateTimePicker1.Value.ToString();
            useraccount.PhoneNo=phonetxt.Text;
            if(maleradio.Checked==true)
            {
                useraccount.Gender = "male";

            }
            else if (femaleradio.Checked == true)
            {
                useraccount.Gender = "female";
            }
            useraccount.Address = addresstxt.Text;
            dbe.SaveChanges();
            MessageBox.Show("record updated");

        }
    }
}
