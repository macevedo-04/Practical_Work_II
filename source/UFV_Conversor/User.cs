using System.Text.RegularExpressions;

namespace UFV_Conversor
{
    public class User
    {
        public string name;
        public string username;
        public string email;
        public string password;
        public int numOperations;

        // Constructor with parameters
        public User(string name, string username, string email, string password)
        {
            this.name = name;
            this.username = username;
            this.email = email;
            this.password = password;
            numOperations = 0;
        }

        // Method to validate password requirements
        public static bool IsPasswordValid(string password)
        {
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasNumber = new Regex(@"[0-9]+");
            var hasSpecialChar = new Regex(@"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]+");

            return password.Length >= 8 &&
                   hasUpperChar.IsMatch(password) &&
                   hasLowerChar.IsMatch(password) &&
                   hasNumber.IsMatch(password) &&
                   hasSpecialChar.IsMatch(password);
        }

        // Method to validate email format
        public static bool IsEmailValid(string email)
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return emailRegex.IsMatch(email);
        }

        // Method to increment the operations count
        public void IncrementOperationsCount()
        {
            this.numOperations++;
        }
    }
}