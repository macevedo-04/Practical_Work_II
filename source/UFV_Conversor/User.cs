using System.Text.RegularExpressions;

namespace UFV_Conversor
{
    public class User
    {
        private string name;
        private string username;
        private string email;
        private string password;
        private int numOperations;

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