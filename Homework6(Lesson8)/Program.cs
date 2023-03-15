using System;
namespace Homework6_Lesson8_
{
    internal class Program
    {
        //P.1


        /*static bool CompareTwoArrays(char[] a, char[] b)
        {
            if (a.Length != b.Length) 
                { 
                    return false; 
                }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) 
                { 
                    return false; 
                }
            }
            return true;

            Console.WriteLine(CompareTwoArrays);
        }*/

        
        //P.2 (attempt 1)


        /*static int Analyze (string stringAnalysis)
        {
            
            int alphabet, digit, specialchar, i, l;
            alphabet = digit = specialchar = i = 0;
            l = stringAnalysis.Length;
            

            while (i < l)
            {
                if ((stringAnalysis[i] >= 'a' && stringAnalysis[i] <= 'z') || (stringAnalysis[i] >= 'A' && stringAnalysis[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (stringAnalysis[i] >= '0' && stringAnalysis[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }

                i++;
            }
            return (alphabet, digit, specialchar).digit ;
            
        }*/

        //P.2 (Attempt 2)


        /*static string SortedString (string EnteredString)
         {
             string temp;
             char[] charString = EnteredString.ToCharArray();
             for (int i = 1; i < charString.Length; i++)
             {
                 for (int j = 0; j < charString.Length - 1; j++)
                 {
                     if (charString[j] > charString[j + 1])
                     {
                         temp = charString[j];
                         charString[j] = charString[j + 1];
                         charString[j + 1] = temp;
                     }
                 }
             }
             return charString;  
         }*/

        
        //P.3 Sort that will return string that contains all characters from input string sorted in alphabetical order (e.g. 'Hello' -> 'ehllo')
        
        
        /*static string SortedString (string enteredString)
        {
            
            char[] characters = enteredString.ToArray();
            Array.Sort(characters);
            return new string(characters);
            
        }*/

        //P.4


        
            static void Main(string[] args)
        {

            //P.1 Compare that will return true if 2 strings are equal, otherwise false, but do not use build-in method

            /*string FirstString, SecondString;
             string FirstStringToLower, SecondStringToLower;
             bool result;

             Console.Write("Enter the First string: ");
             FirstString= Console.ReadLine();

             Console.Write("Enter the Second string: ");
             SecondString= Console.ReadLine();

             FirstStringToLower = FirstString.ToLower ();
             SecondStringToLower = SecondString.ToLower();

             char[] FirstStringArray = FirstStringToLower.ToCharArray();
             char[] SecondStringArray = SecondStringToLower.ToCharArray();

             result = CompareTwoArrays(FirstStringArray, SecondStringArray);

             Console.WriteLine(result);*/

            //P.2

            /*string str;
            int alphabet, digit, specialchar, i, l;
            alphabet = digit = specialchar = i = 0;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            l = str.Length;

            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }

                i++;
            }


            Console.Write("Number of Alphabets in the string is : {0}\n", alphabet); 
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", specialchar);

            Console.ReadLine();*/

            //P.3

            /*string enteredString;

            Console.Write("Enter the string : ");
            enteredString = Console.ReadLine();

            string sortedNew = SortedString(enteredString);
            Console.WriteLine(sortedNew);*/

            //P.4


        }

    }
}