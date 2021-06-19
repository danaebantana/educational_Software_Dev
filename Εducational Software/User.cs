using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Εducational_Software
{
    public class User
    {
        private string name, surname, email, username, password;

        public User()
        {

        }

        public User(string _name, string _surname, string _email, string _username, string _password)
        {
            this.name = _name;
            this.surname = _surname;
            this.email = _email;
            this.username = _username;
            this.password = _password;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(String _name)
        {
            this.name = _name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public void SetSurname(String _surname)
        {
            this.surname = _surname;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(String _email)
        {
            this.email = _email;
        }

        public string GetUsername()
        {
            return this.username;
        }

        public void SetUsername(String _username)
        {
            this.username = _username;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public void SetPassword(String _password)
        {
            this.password = _password;
        }
    }
}
