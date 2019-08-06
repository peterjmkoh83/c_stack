using System;
using System.Collections.Generic;


namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // // Three Basic Arrays
            // int[] array = new int[] {0,1,2,3,4,5,6,7,8,9};
            string[] arrayName = new string[] {"Tim","Martin","Nikki","Sara"};
            // bool[] arrayBool = new bool[] {true,false,true,false,true,false,true,false,true,false};
            
            // // List of Flavors
            List<string> arrayFlavor = new List<string> {"strawberry", "kiwi", "banana", "lychee", "peach"};
            // System.Console.WriteLine($"Following are all flavors of fruits:  {arrayFlavor.Count} ");
            // System.Console.WriteLine($"The third flavor in the list is: {arrayFlavor[2]}");
            // arrayFlavor.RemoveAt(2);
            // foreach (string fruit in arrayFlavor)
            // {
            //     System.Console.WriteLine(fruit);
            // }
            // System.Console.WriteLine(arrayFlavor.Count);
            

            // // User Info Dictionary
            // Random rand = new Random();
           
            Dictionary<string,string> user = new Dictionary<string,string>();
            {
                foreach (string name in arrayName)
                {
                    Random rand = new Random();
                    System.Console.WriteLine(name + " - " + arrayFlavor[rand.Next(0,4)]);
                }
            }
            
        }
    }
}
