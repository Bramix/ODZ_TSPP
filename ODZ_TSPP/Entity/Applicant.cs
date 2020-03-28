namespace ODZ_TSPP.Entity
{
    public class Applicant
    {
        private int id;
        private string firstName;
        private string secondName;
        private double marks;
        private int numberOfSchool;

        public Applicant(int id, string firstName, string secondName, double marks, int numberOfSchool)
        {
            this.id = id;
            this.firstName = firstName;
            this.secondName = secondName;
            this.marks = marks;
            this.numberOfSchool = numberOfSchool;
        }

        public Applicant(string firstName, string secondName, double marks, int numberOfSchool)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.marks = marks;
            this.numberOfSchool = numberOfSchool;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string SecondName
        {
            get => secondName;
            set => secondName = value;
        }

        public double Marks
        {
            get => marks;
            set => marks = value;
        }

        public int NumberOfSchool
        {
            get => numberOfSchool;
            set => numberOfSchool = value;
        }
    }
}