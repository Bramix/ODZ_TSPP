using ODZ_TSPP.Entity;

namespace ODZ_TSPP.Service.Interface
{
    public interface IDataValidator
    {
        bool IsUserDataValid(User user);
        bool IsAddressDataValid(Address address);
        bool IsUserAndAddressDataValid(User user, Address address);
    }
}