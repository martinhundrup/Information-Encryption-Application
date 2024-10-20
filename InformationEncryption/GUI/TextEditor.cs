using Authentication;

namespace GUI
{
    public partial class TextEditor : Form
    {
        private User _user;
        private FileItem _activeFile;

        public TextEditor(User user)
        {
            _user = user;
            InitializeComponent();
            LoadText();
        }

        private void Save_ToolStripItem_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        // inital load
        private void LoadText()
        {
            LoadFile(_user.Directory.Files[0]);

            GenerateFileTabs();
        }

        private void GenerateFileTabs()
        {
            // get collection of filetabs
            List<ToolStripItem> items = new List<ToolStripItem>();
            foreach (ToolStripItem item in Open_ToolStripItem.DropDownItems)
            {
                items.Add(item);
            }

            // clear old ones
            foreach (ToolStripItem item in items)
            {
                Open_ToolStripItem.DropDownItems.Remove(item);
            }


            // generate tabs with all created files
            foreach (var file in _user.Directory.Files)
            {
                var item = Open_ToolStripItem.DropDownItems.Add(file.Name);
                item.Click += ToolStripMenuItem_Clicked;
            }
        }

        private void SaveText()
        {
            _activeFile.Name = name_textbox.Text; // update file name
            _activeFile.SaveContents(textBox.Text);
            GenerateFileTabs();
        }

        // loads a file in the user's directory
        private void LoadFile(FileItem file)
        {
            name_textbox.Text = file.Name;
            created_label.Text = $"Created: {file.Created.ToString()}";
            modified_label.Text = $"Last Modified: {file.Modified.ToString()}";

            StreamReader fileStream = file.GetFileContents();
            // throw away first three lines - which are metadata
            fileStream.ReadLine();
            fileStream.ReadLine();
            fileStream.ReadLine();

            string encryptedContents = fileStream.ReadToEnd();

            textBox.Text = Encryption.Decrypt(Hashing.StringToHash(encryptedContents), Hashing.Hash(file.FilePath));

            // update active file
            _activeFile = file;
            fileStream.Close();
        }

        private void ToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;

            string fileName = item.Text;

            var file = _user.Directory.GetFile(fileName);

            if (file == null)
            {
                throw new Exception("File name not found in user directory!");
            }

            // saves current file
            SaveText();
            LoadFile(file);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveText();

            var file = _user.Directory.CreateFile();
            LoadFile(file);
            GenerateFileTabs();
        }
    }
}