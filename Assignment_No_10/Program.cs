namespace Assignment_No_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supervisor supervisor = new Supervisor();
            supervisor.Accept();
            supervisor.Print();
            Console.WriteLine("");
            Console.WriteLine(supervisor);
        }
    }

    public class Person
    {
        public int Id { get; set; }

        public void Accept()
        {
            Console.Write("Enter Id : ");
            Id = Convert.ToInt32(Console.ReadLine());
        }
    }

    public class Employee : Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public string DepartmentType { get; set; }

        public static int Count = 1;

        public Employee()
        {
            Id = Count;
            Count++;
        }

        public Employee(double salary, string designation, string departmentType)
        {
            Id = Count;
            Count++;
            Salary = salary;
            Designation = designation;
            DepartmentType = departmentType;
        }

        public void Accept()
        {
            base.Accept();
            Console.Write("Enter Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Designation : ");
            Designation = Console.ReadLine();
            Console.Write("Enter Department Type : ");
            DepartmentType = Console.ReadLine();
        }

        public override string ToString()
        {
            return "Employee { " + Id + "  ," + Salary + " ," + Designation + " ," + DepartmentType + " }";
        }

    }

    public class Supervisor : Employee
    {
        public double subOrdinates { get; set; }

        public Supervisor()
        {
            Designation = "Supervisor";
        }

        public Supervisor(double salary, string departmentType, int subOrdinates) : base(salary, "Supervisor", departmentType)
        {
            this.subOrdinates = subOrdinates;

        }

        public void Accept()
        {
            Console.Write("Enter Id : ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Department Type : ");
            DepartmentType = Console.ReadLine();
            Console.Write("Enter Sub ordinates (Number of Assistance) : ");
            subOrdinates = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Supervisor { " + Id + "  ," + Salary + " ," + Designation + " ," + DepartmentType + " ," + subOrdinates + " }";

        }

        public void Print()
        {
            Console.WriteLine("Id  : " + Id);
            Console.WriteLine("Salary : "+Salary);
            Console.WriteLine("Department Type : "+DepartmentType);
            Console.WriteLine("Designation : "+Designation);
            Console.WriteLine("No of Assistance : " +subOrdinates);
        }
    }
}
