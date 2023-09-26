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
    public partial class DialogBoxtest : Form
    {
        public DialogBoxtest()
        {
            InitializeComponent();
        }

        private void button_clickme_Click(object sender, EventArgs e)
        {   
            // \n = means next line                    
            // to make the dialog box tittle need to ,"messagebox tittle here"
            // need to instantiate Dialogresult the message box to run the yes or no in if else
            DialogResult dr = MessageBox.Show("Yes: ACCEPTED\n2: NOT ACCEPTED\n3:rejected", "choose", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "YES";
            }
            if (dr == DialogResult.No)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "NO";
            }
            if (dr == DialogResult.Cancel)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "ERROR";
            }
        }

        private void button_BACK_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }
    }
}
