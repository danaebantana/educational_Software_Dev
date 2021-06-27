using System;
using System.Data.SQLite;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Εducational_Software.Models;

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
                CreateUsersTable(conn);
                CreateStatisticsTable(conn);
            }
        }

        private void CreateUsersTable(SQLiteConnection conn)
        {
            string sql = "CREATE TABLE IF NOT EXISTS users (id integer primary key autoincrement, name varchar(32), surname varchar(32), email varchar(32), username varchar(32), password varchar(32))";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void CreateStatisticsTable(SQLiteConnection conn)
        {
            string sql = "CREATE TABLE IF NOT EXISTS statistics (user_id integer, quiz_id varchar(32), theory_revisions integer, score real, PRIMARY KEY (user_id, quiz_id))";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
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

                while (rdr.Read())
                {
                    user.SetId(rdr.GetInt32(0));
                    user.SetName(rdr.GetString(1));
                    user.SetSurname(rdr.GetString(2));
                    user.SetEmail(rdr.GetString(3));
                    user.SetUsername(rdr.GetString(4));
                    user.SetPassword(rdr.GetString(5));
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

        public void UpdateStatistics(User user, string quiz_id, int theory_revisions, float score)
        {

            using (var conn = new SQLiteConnection(@"Data Source=database.sqlite3"))
            {
                conn.Open();

                string sql = "INSERT INTO statistics (user_id, quiz_id, theory_revisions, score)" +
                " VALUES(@user_id, @quiz_id, @theory_revisions, @score)" +
                "ON CONFLICT(user_id, quiz_id)" +
                "DO UPDATE SET theory_revisions=excluded.theory_revisions, score=excluded.score;";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@user_id", user.GetId());
                cmd.Parameters.AddWithValue("@quiz_id", quiz_id);
                cmd.Parameters.AddWithValue("@theory_revisions", theory_revisions);
                cmd.Parameters.AddWithValue("@score", score);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public Statistics GetStatistics(User user, string quiz_id)
        {
            Statistics statistics = new Statistics();

            using (var conn = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                conn.Open();

                string sql = "SELECT theory_revisions, score FROM statistics WHERE user_id = @user_id and quiz_id = @quiz_id";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user_id", user.GetId());
                cmd.Parameters.AddWithValue("@quiz_id", quiz_id);

                SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    statistics = new Statistics(user, quiz_id, rdr.GetInt32(0), rdr.GetFloat(1));
                }
                rdr.Close();
            }

            return statistics;
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
