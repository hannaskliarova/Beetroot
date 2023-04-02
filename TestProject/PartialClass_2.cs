using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    partial class PartialClass
    {
        partial void GetInfo1()
        {
            Console.WriteLine("First Class");
        }

        public void CallPartialMethod()
        {
            GetInfo1();
            GetInfo2(); //хоть он  и не реализован
        }

        partial void GetInfo2()
        {
            Console.Write("Second partial method");
        }

        
    }
    public class TryReadonlyField
    {
        public readonly int Field = 1;

        public TryReadonlyField()
        {
            Field = 5;
        }
    }
}
