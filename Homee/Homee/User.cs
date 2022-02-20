using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homee
{
    internal class User
    {
        private string Username;
        private string Password;

        public User(string username, string password )
        {
            Username = username;
            Password = password;    
        }
        public void SetUsername( string username)
        {
            if (username.Length > 6)
            {
                Username = username.Substring( 6 );
            }
            else
            {
                Console.WriteLine("Username duzgun olsun");
            }
        }
        public string GetInfo()
        {
            return $"Username: {Username}\nPassword: {Password}";
        }
    }
}
