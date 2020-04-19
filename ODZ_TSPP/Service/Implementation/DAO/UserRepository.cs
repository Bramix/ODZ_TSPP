using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Interface;
using Org.BouncyCastle.Math;

namespace ODZ_TSPP.Service.Implementation.DAO
{
    public class UserRepository:IUserRepository
    {
        private IDataReaderParser dataReaderParser = new DataReaderParser();

        public List<User> GetAllUsers()
        {
            List <User> applicants = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(ConfigStrings.ConnectionString)) 
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM users u join address a on u.Id = a.UserId", conn)) {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())   
                    {
                        while (reader.Read()) 
                            applicants.Add(dataReaderParser.GetApplicantFromReader(reader));
                    }
            }

            return applicants;
        }

        public User GetUserById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigStrings.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM users u join address a on u.Id = a.UserId where id = @id", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return dataReaderParser.GetApplicantFromReader(reader);
                    
                    return null;
                }
            }
        }

        public int addUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigStrings.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO users (`SecondName`,`YearOfConnection`, `PhoneNumber`) VALUE (@SecondName, @YearOfConnection, @PhoneNumber);",
                    conn))
            {
                conn.Open();
                ProvideAllParametersForUser(cmd, user);
                cmd.ExecuteNonQuery(); 
                user.Address.UserId = (int) cmd.LastInsertedId;
                cmd.CommandText = "INSERT INTO address (`City`,`Street`, `NumberOfHouse`, `NumberOfFlat`, `UserId`) VALUE (@City, @Street, @NumberOfHouse, @NumberOfFlat, @UserId)";
                ProvideAllParametersForAddress(cmd, user.Address);
                return cmd.ExecuteNonQuery();
            }
        }


        public int EditUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigStrings.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(
                "Update users SET SecondName = @SecondName, YearOfConnection = @YearOfConnection,PhoneNumber = @PhoneNumber where id = @id;", conn))
            {
                conn.Open();
                ProvideAllParametersForUser(cmd, user);
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Update address set City = @City, Street = @Street, NumberOfHouse = @NumberOfHouse, NumberOfFlat = @NumberOfFlat, UserId = @UserId where id = @id";
                ProvideAllParametersForAddress(cmd, user.Address);
                cmd.Parameters["@id"].Value = user.Address.Id;

                return cmd.ExecuteNonQuery();
            }
        }
        

        public void RemoveUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigStrings.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM address where id = @id", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", user.Address.Id);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM users where id = @id";
                cmd.Parameters["@id"].Value = user.Id;
                cmd.ExecuteNonQuery();
            }
        }

        private void ProvideAllParametersForUser(MySqlCommand cmd, User user)
        {
            cmd.Parameters.AddWithValue($"@{Namings.SecondName.ToString()}", user.SecondName);
            cmd.Parameters.AddWithValue($"@{Namings.YearOfConnection.ToString()}", user.YearOfConnection);
            cmd.Parameters.AddWithValue($"@{Namings.PhoneNumber.ToString()}", user.PhoneNumber);
        }

        private void ProvideAllParametersForAddress(MySqlCommand cmd, Address address)
        {
            cmd.Parameters.AddWithValue($"@{Namings.City.ToString()}", address.City);
            cmd.Parameters.AddWithValue($"@{Namings.Street.ToString()}", address.Street);
            cmd.Parameters.AddWithValue($"@{Namings.NumberOfFlat.ToString()}", address.NumberOfFlat);
            cmd.Parameters.AddWithValue($"@{Namings.NumberOfHouse.ToString()}", address.NumberOfHouse);
            cmd.Parameters.AddWithValue($"@{Namings.UserId.ToString()}", address.UserId);
        }
    }
}