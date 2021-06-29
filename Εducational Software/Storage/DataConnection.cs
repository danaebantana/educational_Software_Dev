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
                CreateScoresTable(conn);
                CreateTheoryRevisionsTable(conn);
            }
        }

        private void CreateUsersTable(SQLiteConnection conn)
        {
            string sql = "CREATE TABLE IF NOT EXISTS users (id integer primary key autoincrement, name varchar(32), surname varchar(32), email varchar(32), username varchar(32), password varchar(32))";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void CreateScoresTable(SQLiteConnection conn)
        {
            string sql = "CREATE TABLE IF NOT EXISTS scores (id integer primary key autoincrement, user_id integer, quiz_id varchar(32), score real)";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void CreateTheoryRevisionsTable(SQLiteConnection conn)
        {
            string sql = "CREATE TABLE IF NOT EXISTS theory_revisions (user_id integer, quiz_id varchar(32), revisions integer, PRIMARY KEY (user_id, quiz_id))";
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

        public void UpdateTheoryRevisions(User user, string quiz_id, int revisions)
        {
            using (var conn = new SQLiteConnection(@"Data Source=database.sqlite3"))
            {
                conn.Open();

                string sql = "INSERT INTO theory_revisions (user_id, quiz_id, revisions)" +
                " VALUES(@user_id, @quiz_id, @revisions)" +
                "ON CONFLICT(user_id, quiz_id)" +
                "DO UPDATE SET revisions=excluded.revisions";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@user_id", user.GetId());
                cmd.Parameters.AddWithValue("@quiz_id", quiz_id);
                cmd.Parameters.AddWithValue("@revisions", revisions);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertScore(User user, string quiz_id, double score) {
            using (var conn = new SQLiteConnection(@"Data Source=database.sqlite3"))
            {
                conn.Open();

                string sql = "INSERT INTO scores (user_id, quiz_id, score) VALUES(@user_id, @quiz_id, @score)";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@user_id", user.GetId());
                cmd.Parameters.AddWithValue("@quiz_id", quiz_id);
                cmd.Parameters.AddWithValue("@score", score);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public Statistics GetStatistics(User user, string quiz_id)
        {
            Statistics statistics = null;

            using (var conn = new SQLiteConnection("Data Source=database.sqlite3"))
            {
                conn.Open();

                string sql = "SELECT revisions FROM theory_revisions WHERE user_id = @user_id and quiz_id = @quiz_id";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user_id", user.GetId());
                cmd.Parameters.AddWithValue("@quiz_id", quiz_id);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                statistics = new Statistics(user, quiz_id, rdr.Read() ? rdr.GetInt32(0):0);
                rdr.Close();

                sql = "SELECT score FROM scores WHERE user_id = @user_id and quiz_id = @quiz_id";
                cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user_id", user.GetId());
                cmd.Parameters.AddWithValue("@quiz_id", quiz_id);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    statistics.AddScore(rdr.GetDouble(0));
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
