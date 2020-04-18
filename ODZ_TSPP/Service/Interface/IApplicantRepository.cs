using System.Collections.Generic;
using ODZ_TSPP.Entity;

namespace ODZ_TSPP.Service.Interface
{
    public interface IApplicantRepository
    {
        List<User> GetAllApplicants();
        User GetApplicantById(int id);
        int addApplicant(User user);
        int EditApplicant (User user);
        void RemoveApplicantById(int id);
    }
}