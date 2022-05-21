using System;
using System.Collections;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter one for Harmonic");
            Console.WriteLine("enter two for Fibnocii");
            Console.WriteLine("enter three for palindronme");
            Console.WriteLine("enter four for Factors");
            Console.WriteLine("enter five for Delegates");


            int number=int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Harmonic harmonic = new Harmonic();
                    harmonic.harmonicNo();


                    break;
                case 2:
                    Fibnocii fibnocii = new Fibnocii();
                    fibnocii.Fibnoci();

                    break;
                case 3:
                    Palindome palindome = new Palindome();
                    palindome.palindrome();

                    break;
                case 4:
                    Factors fact = new Factors();
                    fact.factors();

                    break;

                case 5:
                    Calculation ob1 = new Calculation(Delegates.Add);
                    ob1.Invoke(40, 30);

                    Calculation ob2 = new Calculation(Delegates.sub);
                    ob2(40, 30);

                    Calculation ob3 = new Calculation(Delegates.mul);
                    ob3(40, 30);

                    Calculation ob4 = new Calculation(Delegates.div);
                    ob4(40, 30);




                    break;






                  

            }




        }
    }
}