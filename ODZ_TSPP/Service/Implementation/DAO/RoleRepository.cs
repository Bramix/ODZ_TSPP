using MySql.Data.MySqlClient;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Interface;
using Org.BouncyCastle.Security;

namespace ODZ_TSPP.Service.Implementation.DAO
{
    public class RoleRepository:IRoleRepository
    {
        public Role GetRoleByName(string roleName)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigStrings.ConnectionString)) 
            using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM roles where NameOfRole = '{roleName}' limit 1;", conn)) {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        return DataReaderParser.GetRoleFromReader(reader);
                }
            }

            throw new InvalidParameterException($"{roleName} is not provided in security - matrix");
        }

        public void UpdatePassword(string roleName, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}