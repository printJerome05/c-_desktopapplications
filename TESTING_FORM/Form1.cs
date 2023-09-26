namespace TESTING_FORM
{
    public partial class Form1 : Form
    {
        String jerome = "awit";
        int num = 1;
        int num2 = 2;
        bool istall = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            label2.Text = "button set clicked";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "FormLoaded";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}