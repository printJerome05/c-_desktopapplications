using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;


namespace TESTING_FORM
{


    public partial class Registerwithdatabase : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=JeromeMarco;Initial Catalog=testusers;Integrated Security=True");
        DataTable dtable = new DataTable();

        public static string Name;
        public static string Email;
        public static string Password;
        public static string Country;

        public Registerwithdatabase()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();

        }

        private void Registerwithdatabase_Load(object sender, EventArgs e)
        {
            dataView();


        }

        //to automatically refresh the data
        public void dataView()
        {

            String querry = "SELECT * FROM Users";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds, "Users");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox_name.Text;
            Email = textBox_email.Text;
            Password = textBox_password.Text;
            Country = comboBox1.Text;



            if (textBox_name.Text == "")
            {
                MessageBox.Show("NAME no input");
            }
            else if (textBox_email.Text == "")
            {
                MessageBox.Show("EMAIL no input");
            }
            else if (textBox_password.Text == "")
            {
                MessageBox.Show("PASWORD no input");
            }
            else if (comboBox1.Text == "Select Country")
            {
                MessageBox.Show("Please select Country");
            }
            else
            {
                try
                {
                    conn.Open();
                    String querry = "INSERT INTO Users (name, email, password, country) VALUES ('" + textBox_name.Text + "','" + textBox_email.Text + "','" + textBox_password.Text + "','" + comboBox1.Text + "')";
                    SqlCommand scd = new SqlCommand(querry, conn);
                    int i = scd.ExecuteNonQuery();
                    if (i != 0)
                    {

                        textBox_name.Text = "";
                        textBox_email.Text = "";
                        textBox_password.Text = "";
                        comboBox1.Text = "";

                        MessageBox.Show("Succefully Registered");
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
                catch
                {
                    MessageBox.Show("Error1");
                }
                finally
                {
                    dataView();
                    conn.Close();
                }

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        // see data to textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox_id.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                textBox_name.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                textBox_email.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                textBox_password.Text = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["country"].Value.ToString();
            }
        }

       
        //delete
        private void button_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            String querrydelete = "DELETE FROM Users WHERE id = '"+int.Parse(textBox_id.Text)+"'";
            SqlCommand sqd = new SqlCommand(querrydelete, conn);
         
            
            int i = sqd.ExecuteNonQuery();
            if(i != 0)
            {
                dataView();
            }
            else
            {
                MessageBox.Show("SelectCell");
            }
            conn.Close();
        }

        //update data
        private void button_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            String querryupdate = "UPDATE Users SET name='"+textBox_name.Text+"', email='"+textBox_email.Text+"', password='"+textBox_password.Text+"', country='"+comboBox1.Text+"' WHERE id='"+int.Parse(textBox_id.Text)+"'";
            SqlCommand sqd = new SqlCommand(querryupdate, conn);



            int i = sqd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("ChangeSuccesful");
                dataView();
            }
            else
            {
                MessageBox.Show("Error");
            }
            conn.Close();
        }


       
    }
}

