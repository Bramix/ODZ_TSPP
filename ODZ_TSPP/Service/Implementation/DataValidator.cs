using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Interface;

namespace ODZ_TSPP.Service.Implementation
{
    public class DataValidator: IDataValidator
    {
        public bool IsUserDataValid(User user)
        {
            return true;
        }

        public bool IsAddressDataValid(Address address)
        {
            return true;
        }

        public bool IsUserAndAddressDataValid(User user, Address address)
        {
            return IsUserDataValid(user) && IsAddressDataValid(address);
        }
    }
}