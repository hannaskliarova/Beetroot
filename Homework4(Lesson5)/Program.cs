using System.Diagnostics.CodeAnalysis;

namespace Homework4_Lesson5_
{
    internal class Program
    {
        //P.1,2
        /*static int MinimumValue(int a, int b)
            {
        return Math.Min (a, b);
            }
        static int MaximumValue(int a, int b) 
            { 
        return Math.Max (a, b);
        }*/

        //P.4 Overload

        /*static int MaxOverload(params int[] args) 
        {
            return args.Max(); 
        }

        static int MinOverLoad(params int[] args2)
        { 
            return args2.Min(); 
        }*/

        //P.3
        static bool TrySumIfOdd(int a, int b, out int sum)

        {
            bool isOdd;
            sum = 0;

            for (var i = 0; i < b; i++)

                sum += 1;
            if (isOdd = sum % 2 == 0)
                { return true;
                }
                
            else
                    { return false;
                    }
            Console.WriteLine(isOdd);
            
        }

        
        //Extra
        /*static string stringMultiplication(string a, int b)
        { return String.Concat(Enumerable.Repeat(a, b)); }*/
        
          
        
        static void Main(string[] args)
        {
            //P.1,2
            /*int enteredParameter1, enteredParameter2, value1, value2;
            Console.WriteLine("Enter the parameter 1: ");
            enteredParameter1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the parameter 2:");
            enteredParameter2 = Convert.ToInt32(Console.ReadLine());
            
            value1 = MinimumValue(enteredParameter2,enteredParameter1);
            Console.WriteLine(value1);

            value2= MaximumValue(enteredParameter1,enteredParameter2);
            Console.WriteLine(value2);*/


            //P.3
            int enteredParameter1, enteredParameter2, result;
            bool Sum;
            Console.WriteLine("Enter the parameter 1: ");
            enteredParameter1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the parameter 2:");
            enteredParameter2 = Convert.ToInt32(Console.ReadLine());

            Sum = TrySumIfOdd((int)enteredParameter1, (int)enteredParameter2, out result);
            Console.WriteLine(Sum);

            //P.4
            //Max
            /*int value1 = 2;
            int value2 = 3;
            int value3 = 4;
            int value4 = 5;
            int MaxValue = MaxOverload(value1, value2, value3, value4);
            Console.WriteLine(MaxValue);

            //Min
            int number1 = 10;
            int number2 = 20;
            int number3 = 30;
            int number4 = 40;
            int MinValue = MinOverLoad(number1,number2, number3, number4);
            Console.WriteLine(MinValue);*/

            //Extra

            /*string str, newString;
            int numberOfTimes;

            Console.WriteLine("Enter any string: ");
            str = Console.ReadLine();

            Console.WriteLine("Enter any number: ");
            numberOfTimes = Convert.ToInt32(Console.ReadLine());

            newString = stringMultiplication (str, numberOfTimes);

            Console.WriteLine(newString);*/

           

        }
        
    }
}