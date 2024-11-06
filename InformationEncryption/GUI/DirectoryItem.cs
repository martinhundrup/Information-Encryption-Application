using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class DirectoryItem
    {
        #region Data Members

        private string _directoryPath;
        private List<FileItem> _files; // all files in the directory

        #endregion

        #region Properties

        public List<FileItem> Files
        {
            get { return _files; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// DO NOT USE.
        /// Default constructor.
        /// </summary>
        public DirectoryItem()
        {
            _files = new List<FileItem>();
            _directoryPath = string.Empty;
        }

        // opens name under current environment path
        // name should be hashed username
        public DirectoryItem(string name)
        {
            _files = new List<FileItem>();
            _directoryPath = Environment.CurrentDirectory + $"\\{name}\\";

            LoadAllFiles();
        }

        #endregion

        // attemps to load all files from the current directory
        private void LoadAllFiles()
        {
            string[] filePaths = null;

            try
            {
                filePaths = Directory.GetFiles(_directoryPath);
            }
            catch // directory doesn't exist
            {
                // create the directory
                Directory.CreateDirectory(_directoryPath);
            }

            if (filePaths == null || filePaths.Length == 0)
            {
                // no files, create one

                // internal name of file will be hashed DateTime.Now to avoid duplicate files
                string hashedName = Hashing.HashToString(Hashing.Hash(DateTime.Now.ToString()));
                string filePath = $"{_directoryPath}{hashedName}.txt";

                _files.Add(new FileItem(filePath));
            }
            else // load each file
            {
                foreach (var file in filePaths) 
                {
                    _files.Add(new FileItem(file));
                }
            }
        }

        // searches for a file based on name
        public FileItem GetFile(string name)
        {

            foreach (var file in _files)
            {
                if (string.Compare(file.Name, name) == 0) // found
                {
                    return file;
                }
            }

            return null;
        }

        public FileItem CreateFile()
        {
            string hashedName = Hashing.HashToString(Hashing.Hash(DateTime.Now.ToString()));
            string newFileName = $"{_directoryPath}{hashedName}";

            var file = new FileItem(newFileName);
            _files.Add(file);
            return file;
        }
    }
}
