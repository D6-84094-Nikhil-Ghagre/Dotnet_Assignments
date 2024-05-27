namespace Assignment_No_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WageEmp wageEmp = new WageEmp();
            wageEmp.Accept();
            wageEmp.Print();
            Console.WriteLine(wageEmp);
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

        public Employee(string designation, string departmentType)
        {
            Id = Count;
            Count++;
            Designation = designation;
            DepartmentType = departmentType;
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

    public class WageEmp : Employee
    {
        public int Hours { get; set; }

        public int Rate { get; set; }

        public WageEmp()
        {
            Designation = "Wage Employee";
        }

        public WageEmp(string departmentType, int hours, int rate) : base("Wage Employee", departmentType)
        {
            Hours = hours;
            Rate = rate;
        }

        public void Accept()
        {
            Console.Write("Enter Department Type : ");
            DepartmentType = Console.ReadLine();
            Console.Write("Enter Hours worked : ");
            Hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Wage Per Hour : ");
            Rate = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("The Id : " + Id);
            Console.WriteLine("The Designation is " +Designation);
            Console.WriteLine("The Department Type is " + DepartmentType);
            Console.WriteLine("The total wage is "+Hours*Rate);
        }

        public override string ToString()
        {
            return "{ Wage Employee "+Id+" ,"+Designation+ " ," + DepartmentType+" ,"+Hours*Rate + " }";
        }
    }
}
