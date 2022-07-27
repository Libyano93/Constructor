﻿using System;

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

            Employee e1 = new Employee();
            e1.Id = 100;
            e1.FName = "Younis";
            e1.LName = "Sultan";

            Employee e2 = new Employee
            {
                Id = 1001,
                FName = "Nasir",
                LName = "Imsalem"
            };

            Employee e3 = new Employee(1002)
            {
                FName = "Isaam",
                LName = "Ali"
            };

            Console.WriteLine(e3.DisplayName());
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public int Id;
        public string FName;
        public string LName;

        public Employee()
        {

        }
        public Employee(int id)
        {
            Id = id;
        }

        public string DisplayName()
        {
            return $"Id: {Id}Name:{FName} {LName}\n";
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
