using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authentication;

namespace GUI
{
    public partial class _2FA : Form
    {
        private string? email = null;
        private string? pass = null;

        public _2FA(string _email, string _pass)
        {
            InitializeComponent();
            email = _email;
            pass = _pass;

            Pin_label.Text = $"Enter the 6-digit pin sent to {email}";
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
            DataManager.CreateUser(email, pass);

            this.Hide();
            TextEditor editor = new TextEditor();
            editor.ShowDialog();
            this.Close();
        }
    }
}
