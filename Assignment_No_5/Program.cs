namespace Assignment_No_5
{

    class Student
    {
        private int _rollNo;

        public int rollno
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }

        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _marks;

        public int marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

        public Student()
        {

        }

        public Student(int rollNo, string name, int marks)
        {
            _rollNo = rollNo;
            _name = name;
            _marks = marks;
        }

        public void AcceptInfo()
        {
            Console.Write("Enter Roll No : ");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Marks : ");
            marks = Convert.ToInt32(Console.ReadLine());
        }


        public void PrintInfo()
        {
            Console.WriteLine("Roll no is " + rollno + " name is " + 
                name + " marks is " + marks);
        }
    }

    internal class Program
    {
        public static Student[] CreateArray(int n)
        {
            Student[] arr = new Student[n];

            for(int i=0; i<n; i++)
            {
                arr[i] = new Student();
                arr[i].AcceptInfo();
            }
            return arr;
        }

        public static Student[] ReverseArray(Student[] stdArray) {
            int n = stdArray.Length;
            Student[] reverseStudentArray = new Student[n];

            for(int i=0; i<n; i++)
            {
                reverseStudentArray[i] = stdArray[n-i-1];
            }
            return reverseStudentArray;
        }
 
         
        static void Main(string[] args)
        {
            int n = 0;
            int choice = 0;
            Student[] stdArray = null;
            Student[] reverseArray = null;
            do
            {
                Console.WriteLine("0 : exit, 1 : create student array, 2 : show students, 3 : reverse the array of student");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 0)
                    Console.WriteLine("Tata..");
                else if(choice == 1)
                {
                    Console.Write("Enter the number of Students to add : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    stdArray =  CreateArray(n);
                }
                else if(choice == 2)
                {
                    for(int i=0; i<stdArray.Length; i++)
                    {
                        stdArray[i].PrintInfo();
                    }
                }
                else if(choice == 3)
                {
                    reverseArray = ReverseArray(stdArray);
                    for(int i=0; i<n; i++)
                    {
                        reverseArray[i].PrintInfo();
                    }
                }
            } while (choice != 0);
        }
    }
}
