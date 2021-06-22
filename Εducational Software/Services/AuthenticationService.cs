using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Εducational_Software.Services
{
    public class AuthenticationService
    {
        private User user;

        public AuthenticationService() { }

        public User Login(String username, String password)
        {
            DataConnection conn = new DataConnection();
            user = conn.GetUser(username, password);

            if (user.GetName() == null)
                throw new InvalidCredentialsException(username);

            return user;
        }

        public void Logout()
        {
            this.user = null;
        }

        public void Register(String name, String surname, String email,
                    String username, String password) 
        {
            DataConnection conn = new DataConnection();
            conn.CreateUser(name, surname, email, username, password);
        }

        public User GetUser() 
        {
            return user;
        }
    }

    class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException() { }

        public InvalidCredentialsException(string username) : base(String.Format("Invalid username or password for user \"{0}\"", username)) {}
    }
}
