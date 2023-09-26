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
    public partial class Confirmation : Form
    {
        Register rr = new Register();
        public Confirmation()
        {
            InitializeComponent();
        }

        private void label_transac_Click(object sender, EventArgs e)
        {

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            // when passing date it need to be not instantiated it should be a form name
            label_fname.Text = Register.fname;
            label_lname.Text = Register.lname;
            label_email.Text = Register.email;
            label_phone.Text = Register.phone;

            if (Register.sms == true)
            {
                label_sms.Text = "✔";
                label_sms.ForeColor = Color.Green;
            }
            if (Register.sms == false)
            {
                label_sms.Text = "X";
                label_sms.ForeColor = Color.Red;
            }

            if (Register.reports == true)
            {
                label_report.Text = "✔";
                label_report.ForeColor = Color.Green;
            }
            if (Register.reports == false)
            {
                label_report.Text = "X";
                label_report.ForeColor = Color.Red;
            }

            if (Register.transaction == true)
            {
                label_transac.Text = "✔";
                label_transac.ForeColor = Color.Green;
            }
            if (Register.transaction == false)
            {
                label_transac.Text = "X";
                label_transac.ForeColor = Color.Red;
            }


        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Register rt = new Register();
            rt.Show();
            this.Hide();
        }
    }
}
