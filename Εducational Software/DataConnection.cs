using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Εducational_Software
{
    class DataConnection
    {
        private static String cs;
        private NpgsqlConnection conn;

        public DataConnection()
        {
            cs = "Host=localhost;Username=postgres;Password=danae123;Database=MATHSTER - EDUCATIONAL SOFTWARE";
            conn = new NpgsqlConnection(cs);
        }

        public User Login(String username, String password)
        {
            conn.Open();
            string sql = "SELECT * FROM users WHERE username = @username and password = @password";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            User user = new User();
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
            conn.Close();

            return user;
        }

        public String RegisterUser(User user)
        {
            try
            {
                conn.Open();
                //USER DETAILS
                string sql = "INSERT INTO users(name,surname,email,username,password)" +
                    " VALUES(@name,@surname,@email,@username,@password)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);               

                cmd.Parameters.AddWithValue("@name", NpgsqlTypes.NpgsqlDbType.Varchar, user.GetName());
                cmd.Parameters.AddWithValue("@surname", NpgsqlTypes.NpgsqlDbType.Varchar, user.GetSurname());
                cmd.Parameters.AddWithValue("@email", NpgsqlTypes.NpgsqlDbType.Varchar, user.GetEmail());
                cmd.Parameters.AddWithValue("@username", NpgsqlTypes.NpgsqlDbType.Varchar, user.GetUsername());
                cmd.Parameters.AddWithValue("@password", NpgsqlTypes.NpgsqlDbType.Varchar, user.GetPassword());
                
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Η εγγραφή έγινε με επιτυχία!";
            }
            catch (PostgresException ex)
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
