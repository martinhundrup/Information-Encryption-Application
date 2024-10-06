using Authentication;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Username_textbox.Clear();
            this.Password_textbox.Clear();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string? user = this.Username_textbox.Text;
            string? pass = this.Password_textbox.Text;

            // check password length
            if (pass == null || pass.Length < 4)
            {
                throw new Exception("Password too short");
            }

            // check the database for existing email
            if (DataManager.UserExist(user))
            {
                if (DataManager.ValidateCredentials(user, pass)) 
                {
                    // valid login
                    string? pin = Emailer.Email(user);
                    if (pin != null)
                    {
                        DataManager.pin = pin;
                        LoadAuthenticationPage(user, pass);
                    }
                    else
                    {
                        throw new Exception("Invalid email address");
                    }
                }
                else
                {
                    throw new Exception("Password does not match");
                }
            }
            else // create user
            {
                string? pin = Emailer.Email(user);
                if (pin != null)
                {
                    // success valid email address
                    DataManager.pin = pin;
                    DataManager.CreateUser(user, pass);
                    LoadAuthenticationPage(user, pass);
                }
                else
                {
                    throw new Exception("Invalid email address");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DataManager.LoadCredentials(); // load at application start
        }

        private void LoadAuthenticationPage(string user, string pass)
        {
            this.Hide();
            _2FA _2FA = new _2FA(this.Username_textbox.Text, this.Password_textbox.Text);
            _2FA.ShowDialog();
            this.Close();
        }
    }
}
