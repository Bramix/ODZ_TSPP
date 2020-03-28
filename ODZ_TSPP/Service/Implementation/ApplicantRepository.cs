using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Interface;

namespace ODZ_TSPP.Implementation
{
    public class ApplicantRepository:IApplicantRepository
    {
        public List<Applicant> GetAllApplicants()
        {
            List <Applicant> applicants = new List<Applicant>();
            using (MySqlConnection conn = new MySqlConnection(Configs.connectionString)) 
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

        public Applicant GetApplicantById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(Configs.connectionString))
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

        public int addApplicant(Applicant applicant)
        {
            using (MySqlConnection conn = new MySqlConnection(Configs.connectionString))
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO users (`FirstName`, `SecondName`, `Mark`, `NumberOfSchool`) VALUE (@FirstName, @SecondName, @Mark, @NumberOfSchool);", conn))
            {
                conn.Open();
                ProvideAllParameters(cmd, applicant);
                return cmd.ExecuteNonQuery();
            }
        }

        public int EditApplicant(Applicant applicant)
        {
            using (MySqlConnection conn = new MySqlConnection(Configs.connectionString))
            using (MySqlCommand cmd = new MySqlCommand("Update users SET FirstName = @FirstName, SecondName = @SecondName, Mark = @Mark, NumberOfSchool = @NumberOfSchool where id = @id;", conn))
            {
                conn.Open();
                ProvideAllParameters(cmd, applicant);
                cmd.Parameters.AddWithValue("@id", applicant.Id);
                return cmd.ExecuteNonQuery();
            }
        }

        public void RemoveApplicantById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(Configs.connectionString))
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM users where id = @id", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }
        }

        private Applicant GetApplicantFromReader(MySqlDataReader reader)
        {
            return new Applicant(reader.GetInt32(0),
                reader.GetString(1),
                reader.GetString(2),
                reader.GetDouble(3),
                reader.GetInt32(4));
        }

        private void ProvideAllParameters(MySqlCommand cmd, Applicant applicant)
        {
            cmd.Parameters.AddWithValue("@FirstName", applicant.FirstName);
            cmd.Parameters.AddWithValue("@SecondName", applicant.SecondName);
            cmd.Parameters.AddWithValue("@Mark", applicant.Marks);
            cmd.Parameters.AddWithValue("@NumberOfSchool", applicant.NumberOfSchool);
        }
    }
}