using Authentication;

namespace GUI
{
    public partial class TextEditor : Form
    {
        private string user; // the username of the logged in user
        private static string fileName = string.Empty;

        public TextEditor(string _user)
        {
            user = _user;
            fileName = Environment.CurrentDirectory + $"\\{user}.txt";
            InitializeComponent();
            LoadText();
        }

        private void Save_ToolStripItem_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        private void LoadText()
        {
            FileStream file = null;

            try
            {
                file = new FileStream(fileName, FileMode.Open);
            }
            catch
            {
                return;
            }            

            if (file == null) return;
            using (StreamReader reader = new StreamReader(file))
            {
                textBox.Text = Encryption.Decrypt(Hashing.StringToHash(reader.ReadToEnd()), Hashing.Hash(user));
            }
        }

        private void SaveText()
        {
            try
            {
                using (var file = new FileStream(fileName, FileMode.Open))
                {
                    file.SetLength(0); // clear file
                }
            }
            catch // creat a new file
            {
                File.Create(fileName).Close();
            }

            using (var file = new StreamWriter(fileName))
            {
                file.Write(Hashing.HashToString(Encryption.Encrypt(textBox.Text, Hashing.Hash(user))));
            }
        }
    }
}
