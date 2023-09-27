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
    public partial class DataGrid : Form
    {
        DataTable dtgrid = new DataTable();
        DataTable dtgrid1 = new DataTable();
        public DataGrid()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {
            filldata();
            selectdata();

            listBox1.DataSource = dtgrid;
            listBox1.DisplayMember = "Coursename";

            listBox2.DataSource = dtgrid1;
            listBox2.DisplayMember = "Coursename";

        }

        private void filldata()
        {
            dtgrid.Columns.Add("CourseId", typeof(int));
            dtgrid.Columns.Add("Coursename");
            dtgrid.Columns.Add("CourseDuration");

            dtgrid.Rows.Add(1, "PROGRAMMING", "60 HRS");
            dtgrid.Rows.Add(2, "ENLGISH", "70 HRS");
            dtgrid.Rows.Add(3, "MATH", "50 HRS");
            dtgrid.Rows.Add(4, "SCIEND", "40 HRS");
        }

        private void selectdata()
        {
            dtgrid1.Columns.Add("CourseId", typeof(int));
            dtgrid1.Columns.Add("Coursename");
            dtgrid1.Columns.Add("CourseDuration");


        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                dtgrid1.ImportRow(dtgrid.Rows[listBox1.SelectedIndex]);
                dtgrid.Rows[listBox1.SelectedIndex].Delete();
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                dtgrid.ImportRow(dtgrid1.Rows[listBox2.SelectedIndex]);
                dtgrid1.Rows[listBox2.SelectedIndex].Delete();
            }
        }
    }
}
