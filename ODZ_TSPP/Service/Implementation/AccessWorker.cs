using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Implementation.DAO;
using ODZ_TSPP.Service.Interface;

namespace ODZ_TSPP.Service.Implementation
{
    public class AccessWorker: IAccessWorker
    {
        private IRoleRepository roleRepository = new RoleRepository();
        public bool CheckUserRole(string userRole, string password)
        {
            var roleFromMatrix = roleRepository.GetRoleByName(userRole);
            var currentRole = new Role(userRole, password);
            return roleFromMatrix.Equals(currentRole);
        }

        public bool CheckAccess(string role, string operation)
        {
            return SecurityMatrix.securityMatrix
                .First(pair => pair.Key.ToLower().Equals(role.ToLower()))
                .Value
                .First(op => op.Key.ToLower().Equals(operation.ToLower()) 
                             || op.Key.Equals(UserOperations.AllowAll.ToString()))
                .Value;
        }

        public string EncryptPassword(string password)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}