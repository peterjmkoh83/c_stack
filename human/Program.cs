using System;
using System.Collections.Generic;

namespace human
{
    class Human
    {
        // Fields For Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // health property
        public int Health
        {
            get { return health; }
        }

        // constructor takes value to set Name, and remaining field to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // constructor to assign customer values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int life)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = life;
        }

        public int Attack(Human target)
        {
            int dmg = this.Strength * 5;
            target.health -= dmg;
            System.Console.WriteLine($"The target health is reduced by {dmg} and it's remaining health is {target.health}");
            return target.health;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Human player1 = new Human("David");
            Human player2 = new Human("Mike", 10, 10, 10, 200);
            System.Console.WriteLine(player1.Name);
            System.Console.WriteLine(player2.Name); 
            player1.Attack(player2);
        }
    }
}
