using System.Collections.Generic;

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

        public User(List<string> properties)
        {
            this.secondName = properties[0];
            this.yearOfConnection = int.Parse(properties[1]);
            this.phoneNumber = properties[2];
            this.address = new Address(properties[3], properties[4], 
                properties[5], int.Parse(properties[6]));
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
            return $"{nameof(secondName)}: {secondName}, {nameof(yearOfConnection)}: {yearOfConnection}, {nameof(phoneNumber)}: {phoneNumber}, {address}";
        }

        public string ToString(bool secondNameB, bool yearOfConnectionB,bool phoneNumberB, bool addressB, bool idB)
        {
            string line = string.Empty;
            if (secondNameB) line += $"{nameof(secondName)}: {secondName}, ";

            if (yearOfConnectionB) line += $"{nameof(yearOfConnection)}: {yearOfConnection}, ";

            if (phoneNumberB) line += $"{nameof(phoneNumber)}: {phoneNumber}, ";

            if (addressB) line += $"{nameof(address)}: {address}, ";

            if (idB) line += $"{nameof(id)}: {id}";

            return line;
        }
    }
}