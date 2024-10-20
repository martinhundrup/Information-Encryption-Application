using Authentication;

namespace GUI
{
    public partial class _2FA : Form
    {
        //private string? email = null;
        //private string? pass = null;
        User _user;

        //public _2FA(string _email, string _pass)
        public _2FA(User user) // replace user/pass with user
        {
            InitializeComponent();
            _user = user;

            Pin_label.Text = $"Enter the 6-digit pin sent to {user.Username}";
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            // add fields to the credentials file
            // TODO: add try/catch

            if (string.Compare(DataManager.pin, Pin_textbox.Text) == 0)
            {
                // verified
                this.Hide();
                TextEditor editor = new TextEditor(_user);
                editor.ShowDialog();
                this.Close();
            }
            else
            {
                throw new Exception("Invalid pin");
            }            
        }
    }
}
