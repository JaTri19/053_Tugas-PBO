using System;

namespace Constructor
{
    public class Program
    {
        public class User
        {
            public string username;
            public string password;

            public User(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

        }
        public static void Main(string[] args)
        {
            User petani = new User("Jarwo Trimulyo", "21051214053");
            Console.WriteLine("Username: " + petani.username);
            Console.WriteLine("Password: " + petani.password);
            Console.ReadLine();
        }
    }
}
