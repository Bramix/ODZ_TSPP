using System;
using System.Collections.Generic;

namespace ODZ_TSPP.Service.Interface
{
    public interface IAccessWorker
    {
        bool CheckUserRole(string userRole, string password);
        bool CheckAccess(string role, string operation);
        string EncryptPassword(string password);
    }
}