namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void Clear_Click(object sender, EventArgs e)
        {
            this.Username_textbox.Clear();
            this.Password_textbox.Clear();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            // check the database for existing email



            // if not found, attempt to send an email
            //      if the email fails, display error message
            //      if email succeeds, register email and password
            //          move onto authorization page
            // if the email is already found, then check the password
            // if the password is incorrect, display error message
            // if the password matches, attempt to send email
            //      if the email fails, diplay error message
            //      if the emails succeeds, move onto authorization page

            this.Hide();
            _2FA _2FA = new _2FA(this.Username_textbox.Text, this.Password_textbox.Text);
            _2FA.ShowDialog();
            this.Close();
        }
    }
}
