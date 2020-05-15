using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODZ_TSPP.Entity;

namespace ODZ_TSPP.Service.Implementation.DAO
{
    class CurrentUserRepository
    {
        private static List<User> currentUsers = new List<User>();

        public static List<User> GetAllCurrentUsers()
        {
            return currentUsers;
        }
        public static void SetAllCurrentUsers(List<User> users)
        {
            currentUsers = users;
        }

    }
}
