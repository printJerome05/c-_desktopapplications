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
    class Users
    {




        public void Login()
        {
            LoginForm lf = new LoginForm();
            Form1 f1 = new Form1();

            DataTable dtable = new DataTable();
            SqlConnection conn = new SqlConnection(@"Data Source=JeromeMarco;Initial Catalog=testusers;Integrated Security=True");





            try
            {
                // need to sset modifiers of textbox of targeted input box
                // this string querry value is a querry that we will run on the sql table database
                String querry = "SELECT * FROM Users WHERE email = '"+lf.textBox_emaildatabase.Text+"'AND password = '"+lf.textBox_passworddatabase.Text+"'";

                //converting the string querry for it to be a sqlcommand
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);


                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    LoginForm.databaseemail = lf.textBox_emaildatabase.Text;
                    LoginForm.databasepassword = lf.textBox_passworddatabase.Text;

                    //page to be loaded
                    
                    f1.Show();
                    lf.Hide();

                }
                else
                {
                    lf.textBox_emaildatabase.Text = "";
                    lf.textBox_passworddatabase.Text = "";
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

        public void register()
        {
            MessageBox.Show("meow");
        }

    }
}
