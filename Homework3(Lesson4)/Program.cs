using System;
using System.Reflection.Emit;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter x parameter: ");
        int parameterX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(parameterX);

        Console.Write("Enter y parameter: ");
        int parameterY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(parameterY);
        
        int totalSumFormula = (parameterY* (parameterY + 1)) / 2 - ((parameterX - 1) * parameterX) / 2;

            if (parameterX != parameterY)

            {
                Console.WriteLine(totalSumFormula);
            }
            
            else if (parameterY == parameterX)
            // но я не вижу смысла прописывать это условие, потому что при x == y, sum всегда будет x&&y?
            {
                Console.WriteLine("The parameters are equal");
            }

            
        }
    }
}