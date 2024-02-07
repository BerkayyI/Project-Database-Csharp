namespace Project_Database_Csharp.User
{
    public class User {
        // Private setters for the attributes
        public string Username { get; private set; }
        public DateTime Birthday { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }

        // Constructor
        public User(string username, string password, DateTime birthday, string name = "") {
            Username = username;
            Password = password;
            Birthday = birthday;
            Name = name;
        }

        // SignIn method
        public User SignIn(string username, string password) {
            if (this.Username == username && this.Password == password) {
                return this;
            }
            return null;
        }

        // SignOut method
        public void SignOut() {
            // You can add any implementation needed when signing out
        }

        // GetName method
        public string GetName() {
            return Name;
        }

        // GetBirthday method
        public DateTime GetBirthday() {
            return Birthday;
        }

        // SetName method
        public void SetName(string name) {
            Name = name;
        }
    }
}
