namespace Assignment_No_2
{   
    internal class Program
    {
        static int Add(int x, int y) {
            return x + y;
        }
        static int Sub(int x, int y) {
            if (x > y)
                return x - y;
            else
                return y - x;
        }
        static int Mul(int x, int y) {
            return x * y;
        }
        static double Div(int x, int y) {
            return x / y;
        }

        static void menu()
        {
            Console.WriteLine("0 : EXIT");
            Console.WriteLine("1 : Addition");
            Console.WriteLine("2 : Substraction");
            Console.WriteLine("3 : Multiplication");
            Console.WriteLine("4 : Division");
            Console.Write("Enter your choice : ");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Number : ");
            int y = Convert.ToInt32(Console.ReadLine());
            int choice = 0;

            do
            {
                menu();
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thank you..");
                        break;
                        
                    case 1:
                        Console.WriteLine(Add(x, y));
                        break;
                    case 2:
                        Console.WriteLine(Sub(x, y));
                        break;
                    case 3:
                        Console.WriteLine(Mul(x, y));
                        break;
                    case 4:
                        Console.WriteLine(Sub(x, y));
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }while (choice != 0);

        }
    }
}
