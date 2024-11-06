using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class User
    {
        #region Data Members

        // all of these are unhashed
        private string _username; // same as email
        private string _password;
        private DirectoryItem _directory;

        #endregion

        #region Properties

        public string Username
        {
            get { return _username; }
        }

        public string Password
        {
            get { return _password; }
        }

        public DirectoryItem Directory
        {
            get { return _directory; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// DO NOT USE.
        /// Default constructor. 
        /// </summary>
        private User()
        {
            _username = string.Empty;
            _password = string.Empty;
            _directory = new DirectoryItem();
        }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="username">Plaintext username</param>
        /// <param name="password">Plaintext password</param>
        public User(string username, string password)
        {
            _username = username;
            _password = password;
            _directory = new DirectoryItem(Hashing.HashToString(Hashing.Hash(_username))); // will be thrown away
        }

        #endregion
    }
}
