using System;
using System.Collections.Generic;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(PrintAll());
            // var x =PrintAll();
            // foreach (var item in x)
            // {
            //     Console.WriteLine(item);
            // }

            Console.WriteLine(PrintValuesFizzBuzz());
            var y = PrintValuesFizzBuzz();
            // Console.WriteLine(y.[1]);
            System.Console.WriteLine(y);



            foreach (var item in y)
            {
                Console.WriteLine(item);
            }
        }

        //  Create a Loop that prints all values from 1-255

        public static List<int> PrintAll()
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < 256; i++)
            {
                newList.Add(i);
            }
            return newList;

        }



        //  Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both

        public static List<int> PrintValues()
        {
            List<int> thisList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        continue;
                    }
                    else
                    {
                        thisList.Add(i);
                        System.Console.WriteLine(i);
                    }
                }
            }
            return thisList;
        }



        //  Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5

        public static List<string> PrintValuesFizzBuzz()
        {
            List<string> theList = new List<string>();

            for (int i = 0; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    theList.Add("Fizz");
                    System.Console.WriteLine("fizz");
                }
                if (i % 5 == 0)
                {
                    theList.Add("Buzz");
                    System.Console.WriteLine("Buzz");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    theList.Add("FizzBuzz");
                    System.Console.WriteLine("FizzBuzz");
                }
            }

            return theList;
        }




// Three Basic Arrays
// Create an array to hold integer values 0 through 9

// int[] array1 = {0,1,2,3,4,5,6,7,8,9};
// int[] array2;
// array2 = new int[] {0,1,2,3,4,5,6,7,8,9};




// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"

// string[] thisString = {"hello","jdf"};
// string[] thisString1;
// thisString1 = new string[] {"hello","jdf"};


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

public static void PrintNumbers()
{
for (int i = 0; i < 256; i++)
{
    System.Console.WriteLine(i);
}
}
// Print odd numbers between 1-255

public static void PrintOdds()
{
    for (int i = 0; i < 256; i++)
    {
    if (1%2 ==1)
    {
            System.Console.WriteLine(i);

    }
    }
}
// Print Sum

public static void PrintSum()
{
    int sum = 0;
    for (int i = 0; i < 255; i++)
    {
        System.Console.WriteLine(i);
        sum += i;
        System.Console.WriteLine(sum);
    }
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New Number: 2 Sum: 3
}
// Iterating through an Array

public static void LoopArray(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
    System.Console.WriteLine(i);
}
foreach (var item in numbers)
{
    System.Console.WriteLine(item);
}
}
// Find Max

public static int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    int max = 0;
    foreach (var item in numbers)
    {
        if (item>max)
        {
            max=item;
        }
    }
return max;

}
// Get Average

public static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    int avg = 0;
    int sum = 0;
    foreach (var item in numbers)
    {
        sum +=item;
    }
        avg = sum/(numbers.Length);
}
// Array with Odd Numbers

 public static int[] OddArray()
{
    int [] newArray = new int[129] ;
    // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
    // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
    for (int i = 0; i < 256; i++)
    {
        if (i%2 == 1)
        {
            newArray[i]=i;
        }
    }
    return newArray;
}
// Greater than Y

public static int GreaterThanY(int[] numbers, int y)
{
    // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
    // That are greater than the "y" value. 
    // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
    // (since there are two values in the array that are greater than 3).
    int counter = 0;
    foreach (var item in numbers)
    {
        if (item>y)
        {
            counter +=1;
        }
    }
    return counter;


}
// Square the Values

public static void SquareArrayValues(int[] numbers)
{
    // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
    int [] newArray = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        int square = i*i;
        newArray[i] = square;
    }
}
// Eliminate Negative Numbers

public static void EliminateNegatives(int[] numbers)
{
    // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
   for (int i = 0; i < numbers.Length; i++)
   {
        if (numbers[i] < 0)
        {
            numbers[i]=0;
        }
    }
}
// Min, Max, and Average

public static void MinMaxAverage(int[] numbers)
{
    // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
    // the minimum value in the array, and the average of the values in the array.
    int min =0;
    int max = 0; 
    int avg = 0;
    int sum = 0;
    
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        if (numbers[i] <min)
        {
            min = numbers[i];
        }
        sum += numbers[i]; 
    }
    avg = sum/numbers.Length;
    System.Console.WriteLine(avg);
    System.Console.WriteLine(min);
    System.Console.WriteLine(max);
    System.Console.WriteLine(sum);

}
// Shifting the values in an array

public static void ShiftValues(int[] numbers)
{
    // Given an integer array, say [1, 5, 10, 7, -2], 
    // Write a function that shifts each number by one to the front and adds '0' to the end. 
    // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
    // it should become [5, 10, 7, -2, 0].
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i]=numbers[i+1];
    }
    numbers[numbers.Length-1]= 0;
}
// Number to String

public static object[] NumToString(int[] numbers)
{
    // Write a function that takes an integer array and returns an object array 
    // that replaces any negative number with the string 'Dojo'.
    // For example, if array "numbers" is initially [-1, -3, 2] 
    // your function should return an array with values ['Dojo', 'Dojo', 2].
       for (int i = 0; i < numbers.Length; i++)
   {
       object [] thisArray = object;
        if (numbers[i] < 0)
        {
            int num = numbers[i];
            string numAsString = num.ToString(); 
            numbers[i]= (int);
        }
    }

}




        //  (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!

    }
}






