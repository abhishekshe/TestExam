using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Palindome
    {
        public void palindrome()
        {
            int num;
            int r;
            int sum = 0;
            int temp;


                
            Console.Write("Enter the Number: ");
            num= int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }
    }
}
