using System.Collections.Generic;
using ODZ_TSPP.Entity;

namespace ODZ_TSPP.Interface
{
    public interface IApplicantRepository
    {
        List<Applicant> GetAllApplicants();
        Applicant GetApplicantById(int id);
        int addApplicant(Applicant applicant);
        int EditApplicant (Applicant applicant);
        void RemoveApplicantById(int id);
    }
}