using System;

namespace Test
{

    public class Harmonic
    {
        public void harmonicNo()
        {
            Console.WriteLine("Enter a  number");


            int num = int.Parse(Console.ReadLine());

            double sum = 0.0;


            for (double count = 1; count <= num; count++)
            {
                Console.Write("1/{0} + ", count);
                sum = sum + 1 / count;
            }


            Console.WriteLine("\nThe sum of {0}  seires is {1}  ", num, sum);
            Console.ReadLine();
        }
    }
}