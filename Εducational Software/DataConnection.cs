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

        public User Login(String username, String password)
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

        public String RegisterUser(User user)
        {
            try
            {
                using (var conn = new SQLiteConnection(@"Data Source=database.sqlite3"))
                {
                    conn.Open();

                    string sql = "INSERT INTO users(name,surname,email,username,password)" +
                    " VALUES(@name,@surname,@email,@username,@password)";

                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name", user.GetName());
                    cmd.Parameters.AddWithValue("@surname", user.GetSurname());
                    cmd.Parameters.AddWithValue("@email", user.GetEmail());
                    cmd.Parameters.AddWithValue("@username", user.GetUsername());
                    cmd.Parameters.AddWithValue("@password", user.GetPassword());

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                return "Η εγγραφή έγινε με επιτυχία!";
            }
            catch (SQLiteException ex)
            {
                //NEEDS FIXING
                if (ex.ErrorCode.ToString().Equals("23505"))
                {
                    return "Το 'Όνομα Χρήστη' υπάρχει ήδη. Επέλεξε κάτι διαφορετικό!";
                }
                else
                {
                    return "Ξαφνικό σφάλμα! Προσπάθησε ξανα!";
                }
            }
        }

    }
}
