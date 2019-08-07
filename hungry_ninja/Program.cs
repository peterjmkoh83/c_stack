using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }

    class Buffet
    {
        public List<Food> Menu;

        // Constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("pizza", 1000, false, false),
                new Food("pasta", 1000, false, false),
                new Food("pho", 500, false, false),
                new Food("kimchi", 100, true, false),
                new Food("ice cream", 700, false, true),
                new Food("Rib", 1300, true, true),
                new Food("Donkasu", 1500, false, true)
            };
            
        }

        // Method
        public Food Serve()
        {
            Random randFood = new Random();
            int randomFood = randFood.Next(Menu.Count);
            // System.Console.WriteLine(Menu[randomFood]);
            // Food chosen = Menu[randomFood];
            // System.Console.WriteLine(chosen.Name);
            return Menu[randomFood];
        }

    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        // Constructor
        public Ninja()
        {
            this.calorieIntake = 0;
            this.FoodHistory = new List<Food>();
        }
        
        public bool isFull
        {
            get 
            {
                if (this.calorieIntake > 1200)
                {
                    return true;
                }
                return false;
                
                
            }
        }

        public void Eat(Food item) 
        {
            if (isFull == false)
            {
                this.calorieIntake += item.Calories;
                FoodHistory.Add(item);
                

            }
            else 
            {
                System.Console.WriteLine("Full and cannot take food anymore");
            }
        }
    }

    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Buffet myBuffet = new Buffet();
            // myBuffet.Serve();  
            Ninja ninja1 = new Ninja();
            // ninja1.Eat();
            while (!ninja1.isFull)
            {
                ninja1.Eat(myBuffet.Serve());
                System.Console.WriteLine(myBuffet.Serve());
            }
           
        }
    }
}
