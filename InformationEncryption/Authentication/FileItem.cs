using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class FileItem
    {
        #region Data Members

        private string _name; // name of the file
        private DateTime _created; // date created
        private DateTime _modified; // date in which it was last modified

        #endregion

        #region Properties

        public string Name
        {
            get { return Name; }
        }

        public DateTime Created
        {
            get { return _created; }
        }

        public DateTime Modified
        {
            get { return _modified; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// DO NOT USE.
        /// Default constructor.
        /// </summary>
        private FileItem()
        {
            _name = string.Empty;
            _created = DateTime.MinValue;
            _modified = DateTime.MinValue;
        }

        #endregion
    }
}
