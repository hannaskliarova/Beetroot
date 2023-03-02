using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P.1
            /*double x, result1, result2, result3, result4, result; 
            Console.Write("Enter the x parameter: ");
            x = Convert.ToDouble(Console.ReadLine());
            result1 = Math.Pow(x, (double) 3 / 1); 
            result2 = result1 * -6;
            result3 = Math.Pow(x, (double) 2 / 1) * 5;
            result4 = x * 10;
            result = result2 + result3 - result4 + 15;
            Console.WriteLine(result);*/


            //P.2
            /*double x, y;
            x = 5;
            y = Math.Abs(x) * Math.Sin(x);
            Console.WriteLine(y);*/


            //P.3
            /*double pi = (double)System.Math.PI;
            int x;
            Console.Write("Enter the x parameter: ");
            x = Convert.ToInt32(Console.ReadLine());
            double result = 2 * pi * x;
            Console.WriteLine(result);*/


            //P.4
            /*int x, y, result;
            x = 3; y = 5;
            result = Math.Max(x, y);
            Console.WriteLine(result);*/



            //Extra
            /*int daysPassed, daysLeft;
           Console.BackgroundColor = ConsoleColor.Magenta;

           Console.Write("How many days left to New Year? ");
           daysLeft = Convert.ToInt32(Console.ReadLine());
           Console.Write("How many days passed from New Year? ");
           daysPassed = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine(daysLeft + " days left to New Year.");
           Console.WriteLine(daysPassed + " days passed from New Year.");*/


            //Extra (2nd attempt)

            DateTime currentDate, passedYear, upcomingYear;
            currentDate = new DateTime(2023, 03, 03, 8, 0, 15);
            passedYear = new DateTime(2022, 12, 31, 8, 0, 15);
            upcomingYear = new DateTime(2023, 12, 31, 8, 0, 15);
            TimeSpan difference1 = currentDate - passedYear;
            TimeSpan difference2 = upcomingYear - currentDate;
            Console.WriteLine(difference1.Days + " days passed from New Year.");
            Console.WriteLine(difference2.Days + " days left to New Year.");

            
            
            
            
            
          











        }
    }
}
