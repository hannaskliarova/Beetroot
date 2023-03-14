namespace Homework6_Lesson8_
{
    internal class Program
    {
        //P.1
        static bool CompareTwoArrays(char[] a, char[] b)
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
        }
        static void Main(string[] args)
        {
            
            //P.1
            string FirstString, SecondString;
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

            Console.WriteLine(result);
            


        }
    }
}