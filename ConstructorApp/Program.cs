using System;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Date d1 = new Date(32, 02, 2000);
            //Date d2 = new Date(12, 2002);

            //Console.WriteLine(d1.GetDate());
            //Console.WriteLine(d2.GetDate());

            Employee e1 =  Employee.Create(1000, "Younis", "Sultan");
           

            Console.WriteLine(e1.DisplayName());
            Console.ReadKey();
        }
    }

    public class Employee
    {
        private Employee()
        {

        }
        private int id;
        private string fname;
        private string lname;

      
        private  Employee(int id, string fname, string lname)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
        }

        public static Employee Create(int id,string fname,string lname)
        {
            return new Employee(id, fname, lname);

        }
        public Employee(int id)
        {
            this.id = id;
        }

        public string DisplayName()
        {
            return $"Id: {id}Name:{fname} {lname}\n";
        }
    }
    public class Date
    {
        private static readonly int[] DaysToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 0001;

        public Date(int year) : this(01, 01, year)
        {

        }
        public Date(int month, int year) : this(01, month, year)
        {

        }

        public Date(int day, int month, int year)
        {
            var isleap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = isleap ? DaysToMonth365 : DaysToMonth366;
                if (day >= 1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }

            }

        }

        public string GetDate()
        {

            return $"{this.day.ToString().PadLeft(2, '0')}-{month.ToString().PadLeft(2, '0')}-{this.year.ToString().PadLeft(4, '0')}";
        }


    }
}
