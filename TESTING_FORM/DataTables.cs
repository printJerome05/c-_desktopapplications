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
    public partial class DataTables : Form
    {
        // instantiate datatable to have a data
        DataTable dtphhones = new DataTable();
        DataTable dtphhones1 = new DataTable();
        public DataTables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "GAMMING 1")
            {
                label_core.Text = "8";
                label_ram.Text = "8 x 2";
                label_gpu.Text = "secret1";
                label_fans.Text = "5 fans";
            }
            if (comboBox1.Text == "GAMMING 2")
            {
                label_core.Text = "6";
                label_ram.Text = "8 x 2";
                label_gpu.Text = "secret2";
                label_fans.Text = "4 fans";
            }
            if (comboBox1.Text == "GAMMING 3")
            {
                label_core.Text = "4";
                label_ram.Text = "8 x 1";
                label_gpu.Text = "secret3";
                label_fans.Text = "4 fans";
            }
            if (comboBox1.Text == "GAMMING 4")
            {
                label_core.Text = "2";
                label_ram.Text = "8 x 1";
                label_gpu.Text = "secret4";
                label_fans.Text = "3 fans";
            }
        }

        private void DataTables_Load(object sender, EventArgs e)
        {
            // calling the method
            phones();

            //assinng the values to the combo box
            comboBox2.DataSource = dtphhones;

            //displaying on what the combo box in drop donw appear
            //basically the collumns 
            comboBox2.DisplayMember = "brand";

            example();

            comboBox3.DataSource = dtphhones1;

            comboBox3.DisplayMember = "brand";
        }

        // making a new method for easier code reading

        private void phones()
        {
            // this should be the first line of code when adding a data to combobox
            // the tittle of data
            dtphhones.Columns.Add("ID", typeof(int));
            // the key or the tittles in data
            // mean its in collums
            dtphhones.Columns.Add("brand");
            dtphhones.Columns.Add("year");
            dtphhones.Columns.Add("battery");
            dtphhones.Columns.Add("isGamming");

            // the values of each key = adding values to each key
            // means its row
            dtphhones.Rows.Add(1, "samsung", "2000", "50040mah", "yes");
            dtphhones.Rows.Add(2, "sony", "20002", "50010mah", "no");
            dtphhones.Rows.Add(3, "xiaomi", "20003", "50020mah", "yes");
            dtphhones.Rows.Add(4, "apple", "20004", "50030mah", "yes");




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_brand.Text = dtphhones.Rows[comboBox2.SelectedIndex]["ID"].ToString();
            label_year.Text = dtphhones.Rows[comboBox2.SelectedIndex]["year"].ToString();
            label_battery.Text = dtphhones.Rows[comboBox2.SelectedIndex]["battery"].ToString();
            label_gamming.Text = dtphhones.Rows[comboBox2.SelectedIndex]["isGamming"].ToString();
        }

        private void example()
        {
            dtphhones1.Columns.Add("SECRET", typeof(int));
            dtphhones1.Columns.Add("brand");
            dtphhones1.Columns.Add("year");
            dtphhones1.Columns.Add("month");

            dtphhones1.Rows.Add(1,"GIGABYTE", "2000", "MARCH");
            dtphhones1.Rows.Add(2,"ASUS", "2001", "FEB");
            dtphhones1.Rows.Add(3,"NVIDA", "2003", "JANUARY");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_examplebrand.Text = dtphhones1.Rows[comboBox3.SelectedIndex]["brand"].ToString();
            label_exampleyear.Text = dtphhones1.Rows[comboBox3.SelectedIndex]["year"].ToString();
            label_exampplemonth.Text = dtphhones1.Rows[comboBox3.SelectedIndex]["month"].ToString();
        }
    }
}
