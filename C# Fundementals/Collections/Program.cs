using System;
using System.Collections.Generic;

namespace Collections
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {0,1,2,3,4,6,7,8,9};
            string[] names = new string[] {"tim","martin","Nikki","Sara"};
            Console.WriteLine(numArray);
            Console.WriteLine(names);
            addingToArray();
            list();



        }



        static void addingToArray()
        {
            string[] terms = new string[10];
            for (int runs = 0; runs < 10; runs++)
            {
                if (runs % 2 == 0)
                {
                    terms[runs] = "true";
                }
                else
                {
                    terms[runs] = "false";
                }
            }

        }


        static void list()
        {
List<string> bikes = new List<string>();
bikes.Add("Kawasaki");
bikes.Add("Triumph");
bikes.Add("BMW");
bikes.Add("Moto Guzzi");
bikes.Add("Harley Davidson");
bikes.Add("Suzuki");
Console.WriteLine(bikes.Count); 
Console.WriteLine(bikes[3]);
bikes.RemoveAt(3);
Console.WriteLine(bikes.Count); 

        }


        static void Dict()
        {
            string[] names = new string[] {"tim","martin","Nikki","Sara"};
            List<string> bikes = new List<string>();
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");
            Console.WriteLine(bikes.Count); 
            Console.WriteLine(bikes[3]);
            bikes.RemoveAt(3);
            Console.WriteLine(bikes.Count); 


            Dictionary<string,string> profile = new Dictionary<string,string>();

            for (int i = 0; i < 10; i++)
            {
                profile.Add(names[i], bikes[i] );

            }
            Console.WriteLine(profile);

        }


    }
}


// Three Basic Arrays
// Create an array to hold integer values 0 through 9
// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
// Create an array of length 10 that alternates between true and false values, starting with true


// List of Flavors
// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
// Output the length of this list after building it
// Output the third flavor in the list, then remove this value
// Output the new length of the list (It should just be one fewer!)


// User Info Dictionary
// Create a dictionary that will store both string keys as well as string values
// Add key/value pairs to this dictionary where:
// each key is a name from your names array
// each value is a randomly select a flavor from your flavors list.
// Loop through the dictionary and print out each user's name and their associated ice cream flavor
// Files