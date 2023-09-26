using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTING_FORM
{
    public partial class Register : Form
    {
        public static string fname;
        public static string lname;
        public static string email;
        public static string phone;
        //for checkboxes
        public static bool sms;
        public static bool reports;
        public static bool transaction;

        // calling the form to pass data


        public Register()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            Confirmation cf = new Confirmation();
            fname = textBox_fname.Text;
            lname = textBox_lname.Text;
            email = textBox_email.Text;
            phone = textBox_phone.Text;


            cf.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sms = true;
                label_sms.Text = "Sms Service activated";
            }
            else
            {
                sms = false;
                label_sms.Text = "....";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                reports = true;
                label_report.Text = "Reports Service activated";
            }
            else
            {
                reports = false;
                label_report.Text = "....";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                transaction = true;
                label_transac.Text = "Transaction Service activated";
            }
            else
            {
                transaction = false;
                label_transac.Text = "....";
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}
