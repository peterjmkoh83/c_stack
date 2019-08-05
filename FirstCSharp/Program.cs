using System;
using System.Collections.Generic;


namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string place = "Coding Dojo";
            // string message = $"Hello {place}";
            // Console.WriteLine(message);
            
            // int num = 0;
            // while (num < 256) {
            //     Console.WriteLine(num);
            //     num ++;
            // }

            // int num = 0; 
            // while (num < 101) {
            //     if (num % 3 == 0 || num % 5 == 0) 
            //     {
            //         if (!(num % 3 == 0 && num % 5 == 0)) 
            //         {
            //             Console.WriteLine(num);
            //         }
                    
                    
            //     }
            //     num++;
            // }

            // int num = 1; 
            // while (num < 101) {
            //     if (num % 3 == 0 && num % 5 == 0) {
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else if (num % 3 == 0){
            //         Console.WriteLine("Fizz");
            //     }
            //     else if (num % 5 == 0){
            //         Console.WriteLine("Buzz");
            //     }
            //     else {
            //         Console.WriteLine(num);
            //     }
                    
            //     num++;
            // }
                    
            //   for (int y = 1; y < 256; y++) {
            //       Console.WriteLine(y);
            //   }      
                
            // for (int y = 1; y < 101 ; y++ ) {
            //     if (y % 3 == 0 || y % 5 == 0) 
            //     {
            //         if (!(y % 3 == 0 && y % 5 == 0)) 
            //         {
            //             Console.WriteLine(y);
            //         }
            //     }
            // } 
                
            
            // for (int num = 1; num < 101; num ++ ) {
            //     if (num % 3 == 0 && num % 5 == 0) {
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else if (num % 3 == 0){
            //         Console.WriteLine("Fizz");
            //     }
            //     else if (num % 5 == 0){
            //         Console.WriteLine("Buzz");
            //     }
            //     else {
            //         Console.WriteLine(num);
            //     } 
            // }  

            // string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
            // // The 'Length' property tells us how many values are in the Array (4 in our example here). 
            // // We can use this to determine where the loop ends: Length-1 is the index of the last value. 
            // for (int idx = 0; idx < myCars.Length; idx++)
            // {
            //     Console.WriteLine($"I own a {myCars[idx]}");
            // }

            //Initializing an empty list of Motorcycle Manufacturers
            // List<string> bikes = new List<string>();
            // //Use the Add function in a similar fashion to push
            // bikes.Add("Kawasaki");
            // bikes.Add("Triumph");
            // bikes.Add("BMW");
            // bikes.Add("Moto Guzzi");
            // bikes.Add("Harley Davidson");
            // bikes.Add("Suzuki");
            // //Accessing a generic list value is the same as you would an array
            // Console.WriteLine(bikes[2]); //Prints "BMW"
            // Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

            // Console.WriteLine("The current manufacturers we have seen are:");
            
            // for (var idx = 0; idx < bikes.Count; idx++)
            // {
            // Console.WriteLine("-" + bikes[idx]);
            // }
            // bikes.Insert(2, "Yamaha");
            // bikes.Remove("Suzuki");
            // bikes.Remove("Yamaha");
            // bikes.RemoveAt(0);

            // foreach (string manu in bikes)
            // {
            // Console.WriteLine("-" + manu);
            // }
            
            Dictionary<string,string> profile = new Dictionary<string,string>();
            //Almost all the methods that exists with Lists are the same with Dictionaries
            profile.Add("Name", "Speros");
            profile.Add("Language", "PHP");
            profile.Add("Location", "Greece");
            Console.WriteLine("Instructor Profile");
            Console.WriteLine("Name - " + profile["Name"]);
            Console.WriteLine("From - " + profile["Location"]);
            Console.WriteLine("Favorite Language - " + profile["Language"]);


        }
    }
}
