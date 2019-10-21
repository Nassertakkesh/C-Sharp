using System;
using System.Collections.Generic;


namespace TheBasic13
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers;
            Console.WriteLine("Hello World!");
            // PrintNumbers();
            // PrintSum();
            // PrintOdds();
            // LoopArray(numbers = new int[] {1,3,5,7,9});
            // FindMax(numbers);
            // GetAverage(numbers);
            // OddArray();
            // GreaterThanY(numbers = new int[] {1,3,5,7,9}, 3);
            // SquareArrayValues(numbers = new int[] {1,3,5,7,9});
            // EliminateNegatives(numbers = new int[] { 1, -3, 5, -7, 9 });
            // MinMaxAverage(numbers = new int[] { 1, -3, 5, -7, 30 });
            // ShiftValues(numbers = new int[] { 1, -3, 5, -7, 30 });
            NumToString(numbers = new int[] { 1, -3, 5, -7, 30 });
      


        }



        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }


        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i = 0; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += i;
                int sumAll = Convert.ToInt32(sum);
                Console.WriteLine("New Number:");
                Console.WriteLine(sum);
            }
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
        }

        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }


        public static void FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = 0;
            foreach (var item in numbers)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);
        }


        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += i;
                int sumAll = Convert.ToInt32(sum);
                avg = sumAll / numbers.Length;
            }
            Console.WriteLine(avg);
        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int[] oddArray = new int[256];

            for (int i = 0; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    oddArray[i] = i;
                }

            }
            // Console.WriteLine(oddArray);
            return oddArray;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            foreach (var item in numbers)
            {
                if (item > y)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
            return count;



        }


        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = numbers[i] * numbers[i];
                Console.WriteLine(numbers[i]);
                numbers[i] = temp;
                Console.WriteLine(numbers[i]);
            }
            // foreach (var item in numbers)
            // {
            //     int temp = item*item;
            //     item = temp;
            // }

        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    Console.WriteLine(numbers[i]);
                    numbers[i] = 0;
                    Console.WriteLine(numbers[i]);

                }

            }
        }


                public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.

            int max = 0;
            int min = 0;
            int sum = 0;
            int avg =0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            avg = sum/numbers.Length;
            
            Console.WriteLine(max); 
            Console.WriteLine(min); 
            Console.WriteLine(avg); 




        }


                public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length-1)
                {
                numbers[i] = numbers[i+1];
                Console.WriteLine(numbers[i]);
                }
                else
                {               
                    numbers[numbers.Length-1] = 0;
                    Console.WriteLine(numbers[i]);

                }

            }
                Console.WriteLine(numbers);

        }


                public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object [] newArray = new object[numbers.Length]; 
                for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                newArray[i] = "Dojo";
                }
                else
                {
                    newArray[i] = numbers[i];
                }
                    Console.WriteLine(newArray[i]);

            }
            
return newArray;

        }











    }
}
