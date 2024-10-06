using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{

    // in charge of storing, updating, and accessing all data for the application
    public static class DataManager
    {
        private static Dictionary<string, string> credentials = new Dictionary<string, string>();
        private static string loginFileName = Environment.CurrentDirectory + "\\login.txt";
        private static bool hasLoaded = false;

        // format of user/password file:
        // username:password
        // where the username and password are hashed

        // updates the credentials list to match whatever is in the file
        private static void LoadCredentials()
        {
            using (var reader = new StreamReader(loginFileName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null) return;

                    var user = line.Split(":")[0];
                    var pass = line.Split(":")[1];
                    credentials.Add(user, pass);
                }
            }
        }

        // overwrites the credentials file with the current stored credentials
        private static void SaveCredentials()
        {
            try
            {
                using (var file = new FileStream(loginFileName, FileMode.Open))
                {
                    file.SetLength(0); // clear file
                }
            }
            catch // creat a new file
            {
                File.Create(loginFileName).Close();
            }
            
            using (var file = new StreamWriter(loginFileName))
            {
                foreach (var line in credentials.Keys)
                {
                    file.WriteLine($"{line}:{credentials[line]}");
                }
            }
        }

        // attempts to add a user to the login file
        public static void CreateUser(string? _username, string? _password)
        {
            if (!hasLoaded) // ensure we load before adding to the dataset
            {
                LoadCredentials();
                hasLoaded = true;
            }

            if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
            {
                throw new ArgumentException("Null arguments");
            }

            if (credentials.ContainsKey(Hashing.HashToString(Hashing.Hash(_username))))
            {
                throw new Exception("Username already exists");
            }

            credentials.Add(Hashing.HashToString(Hashing.Hash(_username)),
                Hashing.HashToString(Hashing.Hash(_password)));

            SaveCredentials();
        }
    }
}
