using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Human
    {
        public static string firstName;
        public static string lastName;

    }
    public class Student:Human
    {
        private string mark;

    }
    public class Worker:Human
    {
        private string wage;
        private string hoursWorked;

        private int CalculateHourlyWage()
        {
            int hourlyWage = 13;
            int workingHours = 8;
            int calc = hourlyWage * workingHours;
            return calc;
        }
    }

}
