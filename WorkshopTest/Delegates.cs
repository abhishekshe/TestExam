using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public delegate void Calculation(int a, int b);
    class Delegates
    {
        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition is" + result);

        }

        public static void sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("substraction is" + result);

        }

        public static void mul(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("multiplication is" + result);

        }

        public static void div(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("division is" + result);

        }
    }
}
