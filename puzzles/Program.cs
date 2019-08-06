using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins(10);
            getNames();
            
        }

        // Random Array
        public static void RandomArray() 
        {
            Random rand = new Random();
            int[] numArr = new int[10];
            int sum = 0;

            for (int val = 0; val < numArr.Length; val++) {
                numArr[val] = rand.Next(5,26);
                System.Console.WriteLine(numArr[val]);
                sum += numArr[val];
            }
            int max = numArr[0];
            int min = numArr[0];
            for (int val = 0; val < numArr.Length; val++) {
                if (numArr[val] > max) {    
                    max = numArr[val];
                }
                if (numArr[val] < min) {
                    min = numArr[val];
                }
            }
            System.Console.WriteLine($"Max is {max} and Min is {min}");
            System.Console.WriteLine("Sum of all the values: " + sum);
        }

        // Coin Flip
        public static string TossCoin() 
        {
            System.Console.WriteLine("Tossing a Coin!");
            string result = "head";
            Random rand = new Random();
            int flip = rand.Next(10);
            if (flip % 2 == 0) {
                result = "tail";
            }
            System.Console.WriteLine(result);
            return result;   
        }

        // Multiple Toss
        public static double TossMultipleCoins(int num)
        {
            double heads = 0;
            double tails = 0;
            for (int i = 0; i < num; i++)
            {
                string outcome = TossCoin();
                if (outcome == "head") 
                {
                    heads += 1;
                }
                else
                {
                    tails +=1;
                }
            }

            double ratio = (heads / tails);
            System.Console.WriteLine($"Ratio of {heads} heads to {tails} tails in {num} of tosses is {ratio}");
            return ratio;   
        }
      
        // Names
        public static string[] getNames()
        {
            string[] names = { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            List<string> newNames = new List<string>();
            foreach (string name in names)
            {
                System.Console.WriteLine(name);
            }
            foreach (string name in names)
            {
                if (name.Length > 5)
                {
                    System.Console.WriteLine("Names longer than 5 characters: " + name);
                } 
            }
            return newNames.ToArray();
        }
    }
}
