using System;
using System.Data.SQLite;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Εducational_Software
{
    class DataConnection
    {
        public DataConnection()
        {

            if (!File.Exists("database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
            }

            using (var conn = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS users (name varchar(32), surname varchar(32), email varchar(32), username varchar(32), password varchar(32))";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public User GetUser(String username, String password)
        {
            User user = new User();

            using (var conn = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                conn.Open();
               
                string sql = "SELECT * FROM users WHERE username = @username and password = @password";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                
                SQLiteDataReader rdr = cmd.ExecuteReader();
                int count = 0;

                while (rdr.Read())
                {
                    user.SetName(rdr.GetString(0));
                    user.SetSurname(rdr.GetString(1));
                    user.SetEmail(rdr.GetString(2));
                    user.SetUsername(rdr.GetString(3));
                    user.SetPassword(rdr.GetString(4));
                    count++;
                }
                rdr.Close();
            }   

            return user;
        }

        public void CreateUser(String name, String surname, String email, String username, String password)
        {
            
            using (var conn = new SQLiteConnection(@"Data Source=database.sqlite3"))
            {
                conn.Open();

                // Check if the username is already in use
                if (CheckUsername(conn,  username))
                    throw new UserExistsException(username);

                string sql = "INSERT INTO users(name,surname,email,username,password)" +
                " VALUES(@name,@surname,@email,@username,@password)";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        private bool CheckUsername(SQLiteConnection conn, String username)
        {
            string sql = "SELECT COUNT(*) FROM users WHERE username = @username";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            int userCount = Convert.ToInt32(cmd.ExecuteScalar());
            return userCount > 0;
        }
    }

    class UserExistsException : Exception
    {
        private String username = "";
        public UserExistsException() { }

        public UserExistsException(string username) : base(String.Format("The user \"{0}\" already exists", username)) 
        {
            this.username = username;
        }

        public String GetUsername()
        {
            return username;
        }
    }
}
