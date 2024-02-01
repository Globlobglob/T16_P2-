using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T16_P2
{
    internal class Program
    {

        static DateTime Print() 
        {
            Console.WriteLine("Day ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year ");
            int year = Convert.ToInt32(Console.ReadLine());
            return new DateTime(year, month, day);
        }
        static void Main(string[] args)
        {
            //Task1
            //DateTime date1 = new DateTime(2024,12,2);
            //DateTime date2 = new DateTime(2012,6, 2);

            //TimeSpan datecalc= date1 - date2;
            //Console.WriteLine(datecalc.Days);

            //Task2
            //DateTime date2 = new DateTime(2022, 2, 1);
            //int daysleft=DateTime.DaysInMonth(date2.Year, date2.Month)-date2.Day;
            //Console.WriteLine($"days till month end :{daysleft}");

            ///Task 3.1
            //DateTime date = Print();
            //DayOfWeek dayOfWeek = date.DayOfWeek;
            //Console.WriteLine($"День недели {dayOfWeek}");
           

            ///Task 3.2
            //DateTime date2 = Print();
            //int dayofYear = date2.DayOfYear;
            //Console.WriteLine($"Порядковый номер даты в году{dayofYear}");

            ///Task 3.3
            DateTime date3 = Print();
            bool isLeapYear = (DateTime.IsLeapYear(date3.Year) ? true : false);
            Console.WriteLine("Leap Year"+isLeapYear);

            Console.ReadKey();
        }
    }
}
