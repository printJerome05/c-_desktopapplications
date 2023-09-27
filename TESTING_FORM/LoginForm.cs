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

namespace TESTING_FORM
{
    public partial class LoginForm : Form
    {
        public static string databaseemail;
        public static string databasepassword;
        DataTable dtable = new DataTable();
     
        SqlConnection conn = new SqlConnection(@"Data Source=JeromeMarco;Initial Catalog=testusers;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        // a function can be called for easier coding
        private void Login()
        {
            string id = textBox_id.Text;
            string pass = textBox_pass.Text;

            if (id == "jerome" && pass == "123")
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                textBox_id.Text = "";
                textBox_pass.Text = "";
                MessageBox.Show("Wrong Email or Password");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_pass.Text = "";

        }

        // in the action button click the keypress for actions using keyboards
        private void textBox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // the e is in the end of the function 
            // this code means if we hit enter in this function it will run login
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                textBox_id.Text = "";
                textBox_pass.Text = "";
            }
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            Register rt = new Register();
            rt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateandTime dt = new DateandTime();
            dt.Show();
            this.Hide();
        }

        private void button_radio_Click(object sender, EventArgs e)
        {
            RadioButtons rb = new RadioButtons();
            rb.Show();
            this.Hide();
        }

        private void button_dialogbox_Click(object sender, EventArgs e)
        {
            DialogBoxtest dbt = new DialogBoxtest();
            dbt.Show();
            this.Hide();
        }

        private void button_book_Click(object sender, EventArgs e)
        {
            BOOKFLIGHT bf = new BOOKFLIGHT();
            bf.Show();
            this.Hide();
        }

        private void button_datatables_Click(object sender, EventArgs e)
        {
            DataTables dts = new DataTables();
            dts.Show();
            this.Hide();
        }

        private void button_datagrid_Click(object sender, EventArgs e)
        {
            DataGrid dg = new DataGrid();
            dg.Show();
            this.Hide();
        }

        private void button_registerdatabase_Click(object sender, EventArgs e)
        {
            Registerwithdatabase rwdb = new Registerwithdatabase();
            rwdb.Show();
            this.Hide();
        }

        private void textBox_emaildatabase_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_logindatabase_Click(object sender, EventArgs e)
        {
            databaseemail = textBox_emaildatabase.Text;
            databasepassword = textBox_passworddatabase.Text;

            if (textBox_emaildatabase.Text == "")
            {
                MessageBox.Show("NO email entered");
            }
            else if (textBox_passworddatabase.Text == "")
            {
                MessageBox.Show("NO password Entered");
            }
            else {
                try
                {
                    conn.Open();
                   
                    // need to sset modifiers of textbox of targeted input box
                    // this string querry value is a querry that we will run on the sql table database
                    String querry = "SELECT * FROM Users WHERE email = '" + textBox_emaildatabase.Text + "'AND password = '" + textBox_passworddatabase.Text + "'";

                    //converting the string querry for it to be a sqlcommand
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    sda.Fill(dtable);
                    

                    if (dtable.Rows.Count > 0)
                    {
                        databaseemail = textBox_emaildatabase.Text;
                        databasepassword = textBox_passworddatabase.Text;

                        //page to be loaded
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Wrong Email/Password");
                        textBox_emaildatabase.Text = "";
                        textBox_passworddatabase.Text = "";
                    }


                }
                catch
                {
                    MessageBox.Show("No user Found");


                }
                finally
                {
                    conn.Close();
                }
            }
           

        }
    }
}
