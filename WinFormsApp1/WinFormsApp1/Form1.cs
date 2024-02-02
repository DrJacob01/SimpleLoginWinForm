namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string username = "username";
        string password = "password";

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == username && passwordBox.Text == password)
            {
                MessageBox.Show("Logged in!");
            }
        }
    }
}