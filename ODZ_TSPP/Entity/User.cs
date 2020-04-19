namespace ODZ_TSPP.Entity
{
    public class User
    {
        private int id;
        private string secondName;
        private int yearOfConnection;
        private string phoneNumber;
        private Address address;

        public User(int id, string secondName, int yearOfConnection, string phoneNumber, Address address)
        {
            this.id = id;
            this.secondName = secondName;
            this.yearOfConnection = yearOfConnection;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public User(string secondName, int yearOfConnection, string phoneNumber, Address address)
        {
            this.secondName = secondName;
            this.yearOfConnection = yearOfConnection;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }


        public int Id
        {
            get => id;
            set => id = value;
        }

        public string SecondName
        {
            get => secondName;
            set => secondName = value;
        }

        public int YearOfConnection
        {
            get => yearOfConnection;
            set => yearOfConnection = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public Address Address
        {
            get => address;
            set => address = value;
        }

        public override string ToString()
        {
            return $"{nameof(id)}: {id}, {nameof(secondName)}: {secondName}, {nameof(yearOfConnection)}: {yearOfConnection}, {nameof(phoneNumber)}: {phoneNumber}, {nameof(address)}: {address.ToString()}";
        }
    }
}