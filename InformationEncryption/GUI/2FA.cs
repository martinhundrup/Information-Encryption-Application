using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class _2FA : Form
    {
        private string? email = null;

        public _2FA(string _email)
        {
            InitializeComponent();
            email = _email;

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
            this.Hide();
            TextEditor editor = new TextEditor();
            editor.ShowDialog();
            this.Close();
        }
    }
}
