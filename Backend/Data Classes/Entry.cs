namespace Password_Manager_Program.Backend.Data_Classes
{
    public class Entry
    {
        // Internal variables
        private readonly string _purpose;
        private readonly string _username;
        private readonly string _password;
        private readonly string _comment;

        // External properties
        public string Purpose { get { return _purpose; } }
        public string Username { get { return _username; } }
        public string Password { get { return _password; } }
        public string Comment { get { return _comment; } }

        public Entry(string purpose, string username, string password, string comment)
        {
            _purpose = purpose;
            _username = username;
            _password = password;
            _comment = comment;
        }
    }
}
