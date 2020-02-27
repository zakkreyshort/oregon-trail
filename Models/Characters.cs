using System;
using System.Collections.Generic;
using Game;

namespace Game.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Money { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Days { get; set; }
        public int Miles { get; set; }
        public int Food { get; set; }

        public Character()
        {
            Name = "";
            Health = 100;
            Money = 100;
            Hunger = 100;
            Happiness = 100;
            Days = 0;
            Miles = 0;
            Food = 0;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetMoney(int money)
        {
            Money = 100;
        }

        public void SetHealth(int health)
        {
            Health = 100;
        }

        public void SetHunger(int hunger)
        {
            Hunger = 100;
        }

        public void SetHappiness(int happiness)
        {
            Happiness = happiness;
        }
        public void AddDays(int days)
        {
            Days += days;
        }

        public void AddMiles(int miles)
        {
            Miles += miles;
        }

        public void AddMoney(int money)
        {
            Money += money;
        }

        public void PayMoney(int money)
        {
            Money -= money;
        }

        public void AddFood(int food)
        {
            Food += food;
        }

        public void Rest(int days)
        {
            for (int i = 0; i < days; i++)
            {
            NextDay();
            Program.player.Health += 5;
            }
        }

        public void Hunt()
        {
            Random rnd = new Random();
            int luckyShot = rnd.Next(1, 15);
            if (luckyShot < 4)
            {
                Console.WriteLine("You got a rabbit!");

Console.WriteLine(@"

               ((`\
            ___ \\ '--._
         .'`   `'    o  )
        /    \   '. __.'
       _|    /_  \ \_\_
jgs   {_\______\-'\__\_\
");


                AddFood(2);
            }
            else if (luckyShot >= 4 && luckyShot <= 9)
            {
                Console.WriteLine("You shot a deer!");
                AddFood(5);
            }
            else if (luckyShot >= 10 && luckyShot <= 13)
            {
                Console.WriteLine("You shot a bison!");
                AddFood(10);
            }
            else 
            {
                Console.WriteLine("You missed, no food for you");
                Happiness -= 5;
            }
        }

        public void NextDay()
        {
            Food -= 5;
            Days += 1;
            if (Hunger <= 50)
            {
                Happiness -= 5;
            }
            if (Food == 0)
            {
                Hunger -= 10;
            }
        }

        public void Flood()
        {
            Money -= 10;
            Happiness -= 10;
            AddDays(3);
            Console.WriteLine("You have " + Program.player.Money + " dollars remaining.");
            Console.WriteLine("You have " + Program.player.Happiness + " happiness remaining.");
            Console.WriteLine("You spent 3 days fixing your wagon." );
        }

        public void CheckStatus()
        {
            Console.WriteLine("You have these supplies at your disposal:");
            Console.WriteLine("You are at " + Program.player.Health + " health.");
            Console.WriteLine("You have " + Program.player.Money + " dollars.");
            Console.WriteLine("You have " + Program.player.Happiness + " happiness.");
            Console.WriteLine("You are " + Program.player.Hunger + " hungry.");
            Console.WriteLine("You have been traveling for " + Program.player.Days + " days.");
            Console.WriteLine("You have traveled " + Program.player.Miles + " miles.");
        }

        public void Continue()
        {
            AddMiles(25);
            NextDay();
        }



    }
}