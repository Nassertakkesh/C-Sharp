using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Buffet newBuffet = new Buffet();
            newBuffet.Serve();
            Ninja ninja1 = new Ninja();
            while (!ninja1.isFull)
            {
            ninja1.Eat(newBuffet.Serve());
            }
            ninja1.Eat(newBuffet.Serve());


        }
    
    }
   

   
    }

    








