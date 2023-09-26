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
    public partial class DateandTime : Form
    {
        public DateandTime()
        {
            InitializeComponent();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            label_datetime.Text = dateTimePicker1.Value.ToString();

            label1.Text = dateTimePicker1.Value.ToShortDateString();

            label2.Text = dateTimePicker1.Value.ToLongDateString();

            label3.Text = dateTimePicker1.Value.TimeOfDay.ToString();

            label4.Text = dateTimePicker1.Value.ToShortTimeString();

            //for custom date and time need to .tostring("mm/dd/yy") codes inside tostring
            label_custom.Text = dateTimePicker1.Value.ToString("MMMM dd, yyy");
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void DateandTime_Load(object sender, EventArgs e)
        {

        }
    }
}
