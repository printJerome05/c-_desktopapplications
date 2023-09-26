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
    public partial class RADIOerrorcheck : Form
    {
        public RADIOerrorcheck()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            RadioButtons rb = new RadioButtons();



            rb.Show();
            this.Close();
        }

        private void RADIOerrorcheck_Load(object sender, EventArgs e)
        {
            if (RadioButtons.errorresult == "Error1")
            {
                radioButton1.Checked = true;
            }
            if (RadioButtons.errorresult == "Error2")
            {
                radioButton2.Checked = true;
            }
            if (RadioButtons.errorresult == "Error3")
            {
                radioButton3.Checked = true;
            }
        }
    }
}
