using System;

namespace Test
{
    class Fibnocii
    {
        public void Fibnoci()
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            int i;
            int number;
            Console.Write("Enter the Value: ");
            number = int.Parse(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

            }
        }
    }
}
