namespace WinFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            string username = txtUsername.Text; // getter block of Text Property of txtUsername(TextBox) is called
            string password = txtPassword.Text; // getter block of Text Property of txtPassword(TextBox) is called
            if (username.Equals("jmc") && password.Equals("bca5th"))
            {
                MessageBox.Show("user valid");
            }
            else
            {
                MessageBox.Show("user invalid");
            }
            -
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); ;
        }
    }
}
