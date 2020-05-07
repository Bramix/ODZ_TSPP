using System;
using ODZ_TSPP.Entity;

namespace ODZ_TSPP.Service.Interface
{
    public interface IRoleRepository
    {
        Role GetRoleByName(string roleName);
        void UpdatePassword(string roleName, string password);
    }
}