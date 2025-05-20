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

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine($"{this.name};{this.username};{this.email};{this.password};{this.numOperations}");
            }
        }
    }
}