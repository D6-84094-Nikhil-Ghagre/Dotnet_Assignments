namespace Assgnment_No_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Accept();
            Console.WriteLine(employee);
        }
    }
    public class Person
    {
        public int Id { get; set; }

        public void Accept() {
            Console.Write("Enter Id : ");
            Id = Convert.ToInt32(Console.ReadLine());
        }
    }

    public class Employee : Person
    { 
        public double Salary { get; set; }
        public string  Designation { get; set; }
        public string DepartmentType { get; set; }

        public static int Count = 1;

        public Employee() {
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
            Salary =Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Designation : ");
            Designation = Console.ReadLine();
            Console.Write("Enter Department Type : ");
            DepartmentType = Console.ReadLine();
        }

        public override string ToString()
        {
            return "Employee { " + Id + "  ," + Salary + " ," + Designation + " ,"+DepartmentType+" }";
        }

    }
}
