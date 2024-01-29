using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Уч__пр_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            int month;
            int day;
            Console.Write("Year ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Month ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Day ");
            day = int.Parse(Console.ReadLine());

            DateClass date = new DateClass(year,month,day);
           

             date.NextDay();
            date.PastDay();
            date.DaysCalc();
            


            Console.ReadKey();

        }
    }
}
