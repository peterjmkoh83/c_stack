using System;
using System.Collections.Generic;

namespace basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numArray = { 3,6,7,1,2 };
            int[] maxArray = { 1,3,5,9,2 };
            int[] avgArray = { 1,2,3,4,5 };
            int[] newArray = { 10,10,10,10,10 };
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(numArray);
            // System.Console.WriteLine(FindMax(maxArray)); 
            // GetAverage(newArray);
            // OddArray();
            // System.Console.WriteLine(GreaterThanY(numArray, 6));
            // SquareArrayValues(numArray);
            
        }

        

        // Square the Values
        public static void SquareArrayValues(int [] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
                System.Console.WriteLine(numbers[i]);
            }
            
        }

        // Greater than Y
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            int[] newArray = {};
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y) 
                {
                    count++;
                }
            }
            return count;
        }

        // Array with Odd Numbers
        public static List<int> OddArray()
        {
            List<int> newList = new List<int>();
            for(int x = 1; x < 256; x++)
            {
                if (x % 2 != 0)
                {
                    newList.Add(x);
                    Console.WriteLine(x);
                }
            }
            return newList;
        }

        // Print 1-255
        public static void PrintNumbers() 
        {
            for (int i = 1; i < 256; i++)
            {
                System.Console.WriteLine(i);
            }
        }
        
        // Print odd numbers between 1-255
        public static void PrintOdds() 
        {
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 != 0) 
                {
                    System.Console.WriteLine(i);
                }
            }
        }

        // Print Sum
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                System.Console.WriteLine("New number: " + i + " Sum: " + (sum += i));
            }
        }

        // Iterating through an Array
        public static void LoopArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            }
        }

        // Find Max
        public static int FindMax(int[] numbers)
        {   
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++) 
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        
        // Get Average
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            
            double avg = sum / numbers.Length;
            System.Console.WriteLine(avg);
        }

    }
}
