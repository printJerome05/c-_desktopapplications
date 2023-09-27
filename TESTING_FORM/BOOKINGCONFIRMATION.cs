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
    public partial class BOOKINGCONFIRMATION : Form
    {
        public BOOKINGCONFIRMATION()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            BOOKFLIGHT bf = new BOOKFLIGHT();
            bf.Show();
            this.Hide();
        }

        private void label_name_Click(object sender, EventArgs e)
        {
         
        }

        private void BOOKINGCONFIRMATION_Load(object sender, EventArgs e)
        {
            label_name.Text = BOOKFLIGHT.fname + ", " + BOOKFLIGHT.lname;
            label_TO.Text = BOOKFLIGHT.to;
            label_from.Text = BOOKFLIGHT.from;
            if (BOOKFLIGHT.passport)
            {
                label_traveldocu.Text = "PASSPORT";
                label_docno.Text = BOOKFLIGHT.docuno;
                label5.Text = "PASSPORT NO:";
                label6.Text = "PASSPORT DATE ISSUE:";
                label7.Text = "PASSPORT DATE EXPIRE:";
            }
            else
            {
                label_traveldocu.Text = "ID";
                label_docno.Text = BOOKFLIGHT.docuno;
                label5.Text = "ID NO:";
                label6.Text = "ID DATE ISSUE:";
                label7.Text = "ID DATE EXPIRE:";
            }
            label_dateissue.Text = BOOKFLIGHT.date1;
            label_expiredate.Text = BOOKFLIGHT.date2;

            label_fdate.Text = BOOKFLIGHT.mfirstdate;
            label_ldate.Text = BOOKFLIGHT.elastdate;

            label_baggage.Text = BOOKFLIGHT.baggage;
        }
    }
}
