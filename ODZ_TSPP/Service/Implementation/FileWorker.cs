using System.Collections.Generic;
using ODZ_TSPP.Entity;

namespace ODZ_TSPP.Service.Implementation
{
    public interface IFileWorker
    {
        List<User> ReadFile();
        void WriteUsersToFile();
    }
}