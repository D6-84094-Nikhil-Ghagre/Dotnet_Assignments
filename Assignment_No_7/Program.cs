using Assignment_No_06;

namespace Assignment_No_7
{
    public class Person
    {
        private string _Name;
        private string _Gender;
        private Date _BirthDate = new Date();
        private string _Address;
        private static int _Age; 

        public Person() { }

        public Person(string name, string gender, Date birthDate, string address)
        {
            _Name = name;
            _Gender = gender;
            _BirthDate = birthDate;
            _Address = address; 
        }

        public string Address
        {
            get { return _Address; } 
            set { _Address = value; }
        }


        public Date BirthDate
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }

        public string Gender
        {
            get { return _Gender; } 
            set { _Gender = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Age
        {
            get { return _Age; }
        }

        public void Accept()
        {
            Console.WriteLine("------- Enter Person Details --------");
            Console.WriteLine("Enter Person Name : ");
            _Name = Console.ReadLine();
            Console.WriteLine("Enter Person Gender : ");
            _Gender = Console.ReadLine();
            Console.WriteLine("Enter Person Birth Date : ");
            _BirthDate.AcceptDate();
            Console.WriteLine("Enter Person Address : ");
            _Address = Console.ReadLine(); 
        }

        public static int CalculateAge(Person p)
        {
            _Age = DateTime.Now.Year - p.BirthDate.Year;
            return _Age;
        }

        public void Print() {
            Console.WriteLine("The name of Person is : "+Name);
            Console.WriteLine("The gender of Person is : " + Gender);
            Console.WriteLine("The birthdate of Person is : " + BirthDate);
            Console.WriteLine("The address of Person is : " + Address);
            Console.WriteLine("The age of Person is : " + CalculateAge(this));
        }

        public override string ToString()
        {
            return " { Person : "+Name+" ,"+Gender+" ,"+BirthDate+" ,"+Address+" ,"+_Age;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Accept();
            person.Print();


        }
    }
}
