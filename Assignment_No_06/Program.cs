namespace Assignment_No_06
{
    public class Date
    {
        private int _Day;
        private int _Month;
        private int _Year;


        public Date() { }

        public Date(int day, int month , int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void AcceptDate()
        {
            Console.Write("Enter day : ");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month : ");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year : ");
            Year = Convert.ToInt32(Console.ReadLine());
        }


        public void PrintDate()
        {
            Console.WriteLine("The Day is "+Day);
            Console.WriteLine("The Month is "+Month);
            Console.WriteLine("The Year is " + Year);
        }

        public override string ToString()
        {
            return "{Date : " + Day + " ," + Month + " ," + Year +" }";

        }

        public static int GetDifference(Date date1, Date date2)
        {
            return date1.Year - date2.Year;
        }

        public static bool IsValid(Date date)
        {
            if(date.Year > 0)
            {
                if(date.Month > 0 &&  date.Month < 12)
                {
                    if(date.Day > 0 && date.Day < 32)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }


        public int Month
        {
            get { return _Month; }
            set { _Month = value; }
        }

        public int Day
        {
            get { return _Day; }
            set { _Day = value; }
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            Date d2 = new Date();
            Console.WriteLine("Enter date 1");
            d1.AcceptDate();
            d1.PrintDate();

            Console.WriteLine("--------- Next Date --------");

            Console.WriteLine("Enter date 2");
            d2.AcceptDate();
            d2.PrintDate();

            Console.WriteLine("Output by ToString of date 1"+d1);
            Console.WriteLine("Output by ToString of date 2" + d2);

            Console.WriteLine("Is date 1 valid "+ Date.IsValid(d1));
            Console.WriteLine("Is date 2 valid " + Date.IsValid(d2));

            Console.WriteLine("The difference between date 1 and date 2 is "+Date.GetDifference(d1, d2));
            Console.ReadLine();



        }
    }
}
