using System;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {

            List<object> bikes = new List<object>();
            bikes.Add(7);
            bikes.Add(28);
            bikes.Add(-1);
            bikes.Add(true);
            bikes.Add("chair");
            int sum = 0;


            foreach (var item in bikes)
            {
                Console.WriteLine(item);
                if (item is int)
                {
                    {
                        sum += Convert.ToInt32(item);
                    }
                }





                Console.WriteLine(bikes);

            }
                            Console.WriteLine(sum);
        }
    }

   }

//  Create an empty List of type object
//  Add the following values to the list: 7, 28, -1, true, "chair"
//  Loop through the list and print all values (Hint: Type Inference might help here!)
//  Add all values that are Int type together and output the sum