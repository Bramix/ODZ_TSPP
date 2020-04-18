using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Interface;

namespace ODZ_TSPP.Implementation
{
    public class ApplicantRepository:IApplicantRepository
    {
        public List<User> GetAllApplicants()
        {
            List <User> applicants = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(Configs.ConnectionString)) 
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", conn)) {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())   
                    {
                        while (reader.Read()) 
                            applicants.Add(GetApplicantFromReader(reader));
                    }
            }

            return applicants;
        }

        public User GetApplicantById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(Configs.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM users where id = @id", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return GetApplicantFromReader(reader);
                    
                    return null;
                }
            }
        }

        public int addApplicant(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(Configs.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO users (`SecondName`,`YearOfConnection`, `PhoneNumber`) VALUE (@SecondName, @YearOfConnection, @PhoneNumber);", conn))
            {
                conn.Open();
                ProvideAllParameters(cmd, user);
                return cmd.ExecuteNonQuery();
            }
        }

        public int EditApplicant(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(Configs.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("Update users SET SecondName = @SecondName, YearOfConnection = @YearOfConnection,PhoneNumber = @PhoneNumber where id = @id;", conn))
            {
                conn.Open();
                ProvideAllParameters(cmd, user);
                cmd.Parameters.AddWithValue("@id", user.Id);
                return cmd.ExecuteNonQuery();
            }
        }

        public void RemoveApplicantById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(Configs.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM users where id = @id", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }
        }

        private User GetApplicantFromReader(MySqlDataReader reader)
        {
            return new User(reader.GetInt32(0),
                reader.GetString(1),
                reader.GetInt32(2),
                reader.GetString(3),
                null);
        }

        private void ProvideAllParameters(MySqlCommand cmd, User user)
        {
            cmd.Parameters.AddWithValue("@SecondName", user.SecondName);
            cmd.Parameters.AddWithValue("@YearOfConnection", user.YearOfConnection);
            cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            //cmd.Parameters.AddWithValue("@NumberOfSchool", user.NumberOfSchool);
        }
    }
}