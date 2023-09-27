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
    public partial class BOOKFLIGHT : Form
    {
        public static Boolean passport, id;
        public static string fname;
        public static string lname;
        public static string to;
        public static string from;
        public static string docuno;
        public static string date1;
        public static string date2;
        public static string mfirstdate;
        public static string elastdate;
        public static string baggage;

        public BOOKFLIGHT()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            BOOKINGCONFIRMATION bfc = new BOOKINGCONFIRMATION();

            fname = textBox_fname.Text;
            lname = textBox_lname.Text;
            docuno = textBox_docu.Text; ;
            to = textBox_to.Text;
            from = textBox_from.Text;
            date1 = dateTimePicker1.Value.ToString("MMMM dd, yyyy");
            date2 = dateTimePicker2.Value.ToString("MMMM dd, yyyy");

            // month calendar have to value a start and end date
            mfirstdate = monthCalendar1.SelectionStart.ToString("MMMM dd, yyyy");
            elastdate = monthCalendar1.SelectionEnd.ToString("MMMM dd, yyyy");

            baggage = numericUpDown1.Value.ToString();


            bfc.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void BOOKFLIGHT_Load(object sender, EventArgs e)
        {
            // means can select date up to 100 days from selected initial date
            monthCalendar1.MaxSelectionCount = 100;
            // means date today only no date below current date
            monthCalendar1.ShowToday = true;
        }

        private void radioButton_passport_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_passport.Checked)
            {
                label_doc.Text = "Passport No:";
                label_dateissue.Text = "Passport date issue";
                label_dateexpire.Text = "Passport expire issue";
                passport = true;
            }

        }

        private void radioButton_id_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_id.Checked)
            {
                label_doc.Text = "id No:";
                label_dateissue.Text = "ID date issue";
                label_dateexpire.Text = "ID expire issue";
                id = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // means the date time picker 2 will be not lower than date1
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }
    }
}
