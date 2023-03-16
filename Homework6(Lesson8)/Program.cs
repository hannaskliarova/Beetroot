using System;
using System.Runtime.InteropServices;

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



        //P.2 (Attempt 2)


        /*static void Analyze(string stringAnalysis, out int alphabet, out int digit, out int specialchar)
        {
            
            Console.Write("Enter the string : ");
            stringAnalysis = Console.ReadLine();
            int i, l;
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
            
        }*/



        //P.3 Sort that will return string that contains all characters from input string sorted in alphabetical order (e.g. 'Hello' -> 'ehllo')


        /*static string SortedString (string enteredString)
        {
            
            char[] characters = enteredString.ToArray();
            Array.Sort(characters);
            return new string(characters);
            
        }*/

        //P.4  Duplicate that will return array of characters that are duplicated in input string (e.g. 'Hello and hi' -> ['h', 'l'])

        static List <char> ListOfDuplicates (string enteredString)
        {
            List <char> duplicates = new List <char> ();
            List <char> seen = new List <char> ();

            foreach (char c in enteredString)
            {
                if (seen.Contains(c) && !duplicates.Contains(c))
                {        
                    duplicates.Add (c);
                }
                else
                {
                    seen.Add (c);
                }
            }
            return duplicates;
        }



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


            //P.3

            /*string enteredString;

            Console.Write("Enter the string : ");
            enteredString = Console.ReadLine();

            string sortedNew = SortedString(enteredString);
            Console.WriteLine(sortedNew);*/

            

           

        }

    }
}