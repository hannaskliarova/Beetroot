using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading.Channels;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*PartialClass newClass = new PartialClass();
            newClass.CallPartialMethod();

            TryReadonlyField newField = new TryReadonlyField();
            Console.WriteLine();
            Console.WriteLine(newField.Field);

            #region Flat

            

            #endregion

            int a = 255;
            byte b = 0;
            
            byte b1 = Convert.ToByte(a);
            
            Console.WriteLine(b1);

            string c = "N";
            char d = Convert.ToChar(c);
            Console.WriteLine(d);

            byte f = 0;
            Console.WriteLine(f++);
            Console.WriteLine(f);

            byte f1 = 0;
            Console.WriteLine(++f1);
            Console.WriteLine(f1);

            byte f2 = 0;
            Console.WriteLine(f2--);
            Console.WriteLine(f2);

            byte m = 4;
            m += 10;
            Console.WriteLine(m);*/

            //sbyte k = 127;

            // checked //контролирует переполнение и анти-переполнение числа
            //{
            //k++;
            //}

            //Console.WriteLine(k);

            //unchecked
            //{
            //k++;
            // }

            //Console.WriteLine(k);

            int j = 9;
            int l = 7;
            object m;
            int o;
            int x = 50;
            string y = Convert.ToString(x);



            m = (j > l) ? o = j : o = l;
            Console.WriteLine(m);
            /* {
                 Console.WriteLine($"{j} > {l}");
             }
             else if (j < l) 
    
             {
                 Console.WriteLine($"{j} < {l}");
             }
             else
             {
                 Console.WriteLine("I give up");
    
             }*/

            /*string usersLogin = "test@gmail.com";
            string usersPassword = "qwerty";
    
            Console.Write("Enter the login: ");
    
            string enteredLogin = Console.ReadLine();
    
            if (usersLogin == enteredLogin)
            {
                Console.Write("Enter the password: ");
                string enteredPassword = Console.ReadLine();
    
                if (usersPassword == enteredPassword)
                {
                    Console.WriteLine("You're singed in!");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Wrong login. Try again.");
    
            }*/
            int counter = 0;
            Hanna:
            counter++;
            Console.WriteLine($"Counter = {counter}");
            if (counter < 5)
            {
                Console.WriteLine("Hi");

                goto Hanna;
            }

            int q = Sum(10, 15);
            string s = Convert.ToString(q);
            Console.WriteLine(s);

            DrawRectangle(10, 30);

            Console.WriteLine("_______________________________________________");

            DrawRectangle(10, 25);

            string e = CompareInts(5, 7);
            Console.WriteLine(e);

            int value = 5;
            int result = ReturnRef(ref value);
            Console.WriteLine($"value is: {value}; result is: {result}");
            Console.WriteLine("{1} and {0}", value, result);
        }

        static int Sum (int v, int w)


        {
            int j = v + w;
            return j;
        }

        static void DrawRectangle(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }

        static string CompareInts(int a, int b)
        {
            if (a > b)
            {
                return "Comparison Less then";
            }
            else if (a < b)
            {
                return "Comparison Greater then";
            }

            return "Parameters are equal";
        }

        static int ReturnRef(ref int value)
        {
            int result2 = value * 2;
            value = 7;
            return result2;
        }

    }
} 