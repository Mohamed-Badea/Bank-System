using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankingApplication_t
{
    public partial class newAccount : Form
    {
        string gender = string.Empty;
        decimal no;
        banking_dbEntities6 BSE;

        public newAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();

        }
       
    

        private void loadaccount()
        {
            BSE = new banking_dbEntities6();
            var item = BSE.userAccounts.ToArray();
            no=item.LastOrDefault().Account_No + 1;
            accnotext.Text = Convert.ToString(no);
            //Var.item=BSE.user
        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maleradio.Checked)
            {
                gender = "male";
            }
            else if(femaleradio.Checked)
            {
                gender = "female";
            }
            BSE = new banking_dbEntities6();
            userAccount acc= new userAccount();
            acc.Account_No = Convert.ToDecimal(accnotext.Text);
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = phonetxt.Text;
            acc.Address = addtxt.Text;
            acc.Gender = gender;
            acc.balance = Convert.ToDecimal(balancetxt.Text);
            acc.Date = datelbl.Text;
            BSE.userAccounts.Add(acc);
            BSE.SaveChanges();
            MessageBox.Show("file saved");



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
