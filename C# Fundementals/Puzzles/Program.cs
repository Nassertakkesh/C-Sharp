using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {


        
        static public int[] RandomArray(int x, int y)
        {
            Random rand = new Random();
            int[] RandomArray = new int[10];
            int max = 0;
            int min = 0;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                RandomArray[i] = rand.Next(x, y);
            }

            for (int i = 0; i < RandomArray.Length; i++)
             
            {
                sum += RandomArray[i];
                if (RandomArray[i]> max)
                {
                    max = RandomArray[i];
                }
                if (RandomArray[i]< min)
                {
                    min = RandomArray[i];
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);

        return RandomArray;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            // RandomArray(5,25);
            // TossCoin(5);
            Names();
        }




        // Random Array
        // Create a function called RandomArray() that returns an integer array

        // Place 10 random integer values between 5-25 into the array
        // Print the min and max values of the array
        // Print the sum of all the values





        static string TossCoin(int num)
        {

            string x = "";
            double y = 1;
            double z = 1;
            double ratio;

            for (int i = 0; i < num; i++)
            {
            Console.WriteLine("Tossing a Coin!!");
            Random rand = new Random();
            Console.WriteLine(rand.Next(1,3));
            int newInt = rand.Next(1,3);
        
            if (newInt == 1 )

            {
                Console.WriteLine("Heads");
                 x = "Heads";
                 y +=1;

            }
            else
            {
                Console.WriteLine("Tails");
                 x = "Tails";
                 z +=1;

            }
            }
            Console.WriteLine(y);
            Console.WriteLine(z);
            ratio = (y/z);
            Console.WriteLine($"this is the ratio:{ratio}");
            return x;

        }

//         Create a function called TossCoin() that returns a string

// Have the function print "Tossing a Coin!"
// Randomize a coin toss with a result signaling either side of the coin 
// Have the function print either "Heads" or "Tails"
// Finally, return the result
// Create another function called TossMultipleCoins(int num) that returns a Double

// Have the function call the tossCoin function multiple times based on num value
// Have the function return a Double that reflects the ratio of head toss to total toss


    







static string Names()
{
Random rand = new Random();
Console.WriteLine(rand.Next(1));
List<string> names = new List<string>();
names.Add("Todd");
names.Add("Tiffany");
names.Add("Charlie");
names.Add("Geneva");
names.Add("Sydney");

Console.WriteLine(names);
Console.WriteLine(names[rand.Next(names.Count)]);
string theboy = names[rand.Next(names.Count)];
return theboy;
}


// Names
// Build a function Names that returns a list of strings.  In this function:

// Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
// Shuffle the list and print the values in the new order
// Return a list that only includes names longer than 5 characters
 }

}
