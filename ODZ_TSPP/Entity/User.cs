namespace ODZ_TSPP.Entity
{
    public class User
    {
        private int id;
        private string secondName;
        private int yearOfConnection;
        private string phoneNumber;
        private Addres addres;

        public User(int id, string secondName, int yearOfConnection, string phoneNumber, Addres addres)
        {
            this.id = id;
            this.secondName = secondName;
            this.yearOfConnection = yearOfConnection;
            this.phoneNumber = phoneNumber;
            this.addres = addres;
        }

        public User(string secondName, int yearOfConnection, string phoneNumber, Addres addres)
        {
            this.secondName = secondName;
            this.yearOfConnection = yearOfConnection;
            this.phoneNumber = phoneNumber;
            this.addres = addres;
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

        public Addres Addres
        {
            get => addres;
            set => addres = value;
        }
    }
}