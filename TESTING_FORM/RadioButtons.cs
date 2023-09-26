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
    public partial class RadioButtons : Form
    {
        public static string test1;
        public static string test2;
        public static string test3;

        public static string result;

        public static string error1;
        public static string error2;
        public static string error3;

        public static string errorresult;

        public RadioButtons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                result = "TEST1";
                MessageBox.Show(result);
            }

            if (radioButton2.Checked == true)
            {
                result = "TEST2";
                MessageBox.Show(result);
            }

            if (radioButton3.Checked == true)
            {
                result = "TEST3";
                MessageBox.Show(result);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void button_error_Click(object sender, EventArgs e)
        {

            if (radioButton4.Checked == true)
            {
                errorresult = "Error1";
            }
            if (radioButton5.Checked == true)
            {
                errorresult = "Error2";
            }
            if (radioButton6.Checked == true)
            {
                errorresult = "Error3";
            }
            RADIOerrorcheck rec = new RADIOerrorcheck();
            rec.Show();
            this.Hide();
        }

        private void RadioButtons_Load(object sender, EventArgs e)
        {

        }
    }
}

