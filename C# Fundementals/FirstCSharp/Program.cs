using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 1; i < 256; i++)
            // {
            //     Console.WriteLine(i);
            // }
            whiileLoop(args);
            skipping35(args);
            skippingWhile(args);
            skippingWhileFizz();
            skipping35Fizz();
        }

        static void whiileLoop(string[] args)
        {
            int j = 1;
            while (j < 256)
            {
                Console.WriteLine(j);
                j += 1;
            }
        }


        static void skipping35(string[] args)
        {
            for (int z = 1; z < 101; z++)
            {
                if (z % 3 == 0 && z % 5 != 0 || z % 5 == 0 && z % 3 != 0)
                {
                    Console.WriteLine(z);
                }
            }
        }

        static void skippingWhile(string[] args)
        {
            int x = 1;
            while (x < 100)
            {
                if (x % 3 == 0 && x % 5 != 0 || x % 5 == 0 && x % 3 != 0)
                {
                    Console.WriteLine(x);
                }
                x += 1;

            }
        }


        static void skipping35Fizz()
        {
            for (int z = 1; z < 101; z++)
            {

                if (z % 3 == 0 && z % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (z % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (z % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }

        static void skippingWhileFizz()
        {
            int z = 1;
            while (z < 100)
            {
                if (z % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (z % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (z % 3 == 0 && z % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                z += 1;
            }


        }
    }




}



//  Create a Loop that prints all values from 1-255
//  Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
//  Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
//  (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!