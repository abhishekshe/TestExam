using System;

namespace Test
{
    class Factors
    {
        public void factors()
        {

            int i;
            Console.WriteLine("Enter the Number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Factors:");
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }

}

