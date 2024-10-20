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

        private List<FileItem> _files; // all files in the directory

        #endregion

        #region Properties

        private List<FileItem> Files
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
        }

        #endregion
    }
}
