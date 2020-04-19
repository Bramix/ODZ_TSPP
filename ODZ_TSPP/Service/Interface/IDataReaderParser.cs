using System.Data;
using ODZ_TSPP.Entity;

namespace ODZ_TSPP.Service.Interface
{
    public interface IDataReaderParser
    {
        User GetApplicantFromReader(IDataReader reader);
        Address GetAddressFromReader(IDataReader reader);
    }
}