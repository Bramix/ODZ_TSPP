using System.Data;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Interface;

namespace ODZ_TSPP.Service.Implementation
{
    public class DataReaderParser
    {
        public static User GetApplicantFromReader(IDataReader reader)
        {
            return new User((int) reader[Namings.Id.ToString()],
                (string) reader[Namings.SecondName.ToString()],
                (int) reader[Namings.YearOfConnection.ToString()],
                (string) reader[Namings.PhoneNumber.ToString()],
                GetAddressFromReader(reader));
        }

        public static Address GetAddressFromReader(IDataReader reader)
        {
            return new Address((int) reader[Namings.Id.ToString()],
                (string) reader[Namings.City.ToString()],
                (string) reader[Namings.Street.ToString()],
                (string) reader[Namings.NumberOfHouse.ToString()],
                (int?) reader[Namings.NumberOfFlat.ToString()],
                (int) reader[Namings.UserId.ToString()]
            );        
        }

        public static Role GetRoleFromReader(IDataReader reader)
        {
            return new Role(
                (int) reader[Namings.Id.ToString()],
                (string) reader[Namings.NameOfRole.ToString()],
                (string) reader[Namings.Password.ToString()]
            );
        }
    }
}