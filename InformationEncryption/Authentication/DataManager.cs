namespace Authentication
{

    // in charge of storing, updating, and accessing all data for the application
    public static class DataManager
    {
        private static Dictionary<string, string> credentials = new Dictionary<string, string>();
        private static string loginFileName = Environment.CurrentDirectory + "\\login.txt";

        private static bool hasInit = false;

        // used to for 2FA
        public static string pin = string.Empty;

        // format of user/password file:
        // username:password
        // where the username and password are hashed

        // updates the credentials list to match whatever is in the file
        public static void LoadCredentials()
        {
            if (hasInit) return;
            hasInit = true;
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

        // checks if an account with that username has already been created
        public static bool UserExist(string? _username)
        {
            if (string.IsNullOrEmpty(_username))
            {
                throw new ArgumentException("Null arguments");
            }

            if (credentials.ContainsKey(Hashing.HashToString(Hashing.Hash(_username))))
            {
                return true;
            }

            return false;
        }

        public static bool ValidateCredentials(string? _username, string? _password)
        {
            string hashedUser = Hashing.HashToString(Hashing.Hash(_username));
            string hashedPass = Hashing.HashToString(Hashing.Hash(_password));

            if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
            {
                throw new ArgumentException("Null arguments");
            }

            if (!credentials.ContainsKey(hashedUser))
            {
                throw new Exception("Username not found");
            }

            return string.Compare(hashedPass, GetPassword(_username)) == 0;
        }

        // returns the hashed password of an account
        private static string GetPassword(string _username)
        {
            if (string.IsNullOrEmpty(_username))
            {
                throw new ArgumentException("Null arguments");
            }

            if (!credentials.ContainsKey(Hashing.HashToString(Hashing.Hash(_username))))
            {
                throw new Exception("Username not found");
            }

            return credentials[Hashing.HashToString(Hashing.Hash(_username))];
        }
    }
}
