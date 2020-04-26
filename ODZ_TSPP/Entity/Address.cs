namespace ODZ_TSPP.Entity
{
    public class Address
    {
        private int id;
        private string city;
        private string street;
        private string numberOfHouse;
        private int ?numberOfFlat;
        private int userId;

        public Address(int id, string city, string street, string numberOfHouse, int ?numberOfFlat, int userId)
        {
            this.id = id;
            this.city = city;
            this.street = street;
            this.numberOfHouse = numberOfHouse;
            this.numberOfFlat = numberOfFlat;
            this.userId = userId;
        }

        public Address(string city, string street, string numberOfHouse, int numberOfFlat)
        {
            this.city = city;
            this.street = street;
            this.numberOfHouse = numberOfHouse;
            this.numberOfFlat = numberOfFlat;
        }

        public int Id => id;

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Street
        {
            get => street;
            set => street = value;
        }

        public string NumberOfHouse
        {
            get => numberOfHouse;
            set => numberOfHouse = value;
        }

        public int? NumberOfFlat
        {
            get => numberOfFlat;
            set => numberOfFlat = value;
        }
        
        public int UserId
        {
            get => userId;
            set => userId = value;
        }

        public override string ToString()
        {
            return $"{nameof(city)}: {city}, {nameof(street)}: {street}, {nameof(numberOfHouse)}: {numberOfHouse}, {nameof(numberOfFlat)}: {numberOfFlat}";
        }
    }
}