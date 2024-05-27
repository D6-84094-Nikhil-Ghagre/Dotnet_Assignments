using System.Data;

namespace Assignment_No_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Accept();
            Console.WriteLine(manager);
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

    public class Manager : Employee
    {
        public double bonus { get; set; }

        public Manager() {
            Designation = "Manager";
        }

        public Manager(double salary, string departmentType ,double bonus) : base(salary,"Manager", departmentType)
        {
            this.bonus = bonus;

        }

        public void Accept()
        {
            Console.Write("Enter Id : ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Enter Department Type : ");
            DepartmentType = Console.ReadLine();
            Console.Write("Enter bonus : ");
            bonus = Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Manager { " + Id + "  ," + Salary + " ," + Designation + " ," + DepartmentType +  " ,"+ bonus+" }";

        }
    }
}
