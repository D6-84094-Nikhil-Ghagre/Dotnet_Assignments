using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Assignment_No_3
{
    public struct Student
    {
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _gender;

        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private int _age;

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        private int _std;

        public int std
        {
            get { return _std; }
            set { _std = value; }
        }

        private char _div;

        public char div
        {
            get { return _div; }
            set { _div = value; }
        }

        private double _marks;

        public double marks
        {
            get { return _marks; }
            set { _marks = value; }
        }
         

        public Student(string name, string gender, int age, int std, char div, double marks)
        {
            _name = name;
            _gender = gender;
            _age = age;
            _std = std;
            _div = div;
            _marks = marks;
        } 

        public void AcceptDetails()
        {
            Console.Write("Enter Student Name : ");
            name = Console.ReadLine();

            Console.Write("Enter Student Gender : ");
            gender = Console.ReadLine();

            Console.Write("Enter Student Age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Standard : ");
            std = Convert.ToInt32(Console.ReadLine());  

            Console.Write("Enter Student Division : ");
            div = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Student Marks : ");
            marks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.Write("The student name is " + name + " ,age is " + age +
                " Gender is : "+gender+" Standard is "+std+" Division is : "+div+" Marks is "+marks); 
        }

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.AcceptDetails();
            std.PrintDetails();
        }
    }
}
