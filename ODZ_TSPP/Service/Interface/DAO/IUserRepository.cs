using System.Collections.Generic;
using ODZ_TSPP.Entity;

namespace ODZ_TSPP.Service.Interface
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        int EditUser (User user);
        int addUser(User user);
        void RemoveUser(User user);
    }
}