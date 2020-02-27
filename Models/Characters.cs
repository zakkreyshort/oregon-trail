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
        public int Happiness { get; set; }
        public int Days { get; set; }
        public int Miles { get; set; }
        public int Food { get; set; }

        public Character()
        {
            Name = "";
            Health = 100;
            Money = 100;
            Happiness = 100;
            Days = 0;
            Miles = 0;
            Food = 50;
        }

        public void SetName(string name)
        {
            Name = name;
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

        public void BuyFood()
        {
            Food += 5;
            Money -= 10;
        }

        public void SellFood()
        {
            Food -= 5;
            Money += 10;
        }


        public void Rest(int days)
        {
            CheckDeath();
            for (int i = 0; i < days; i++)
            {
            NextDay();
            Program.player.Health += 5;
            }
            Console.WriteLine("Now that you are done resting");
            Locations.Menu();
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
         .'`   `'    X  )
        /    \   '. __.'
       _|    /_  \ \_\_
      {_\______\-'\__\_\
");


                AddFood(2);
            }
            else if (luckyShot >= 4 && luckyShot <= 9)
            {
                Console.WriteLine("You shot a deer!");
                Console.WriteLine(
                    @"
                   .     _,
                   |`\__/ /
                   \  x x(
                    | __T|
                   /   |
      _.---======='    |
     //               {}
    `|      ,   ,     {}
     \      /___;    ,'
      ) ,-;`    `\  //
     | / (        ;||
     ||`\\        |||
     ||  \\       |||
     )\   )\      )||
                
                ");

                AddFood(5);
            }
            else if (luckyShot >= 10 && luckyShot <= 13)
            {
                Console.WriteLine("You shot a bison!");
                Console.WriteLine(@"
             _.-````'-,_
   _,.,_ ,-'`           `'-.,_
 /)     (\                   '``-.
((      ) )                      `\
 \)    (_/                        )\
  |       /)           '    ,'    / \
  `\    X'            '     (    /  ))
    |      _/\ ,     /    ,,`\   (  '`
     \Y,   |  \  \  | ````| / \_ \
       `)_/    \  \  )    ( >  ( >
                \( \(     |/   |/
              /_(/_(    /_(  /_(
                
                ");

                AddFood(10);
            }
            else 
            {
                Console.WriteLine("You missed, no food for you");
                Happiness -= 5;
            }
            Locations.Menu();
        }

        public void NextDay()
        {
            CheckDeath();
            Food -= 5;
            Days += 1;
            if (Food <= 50)
            {
                Health -= 5;
            }
            if (Food == 0)
            {
                Health -= 15;
            }
            if (Happiness <= 75)
            {
                Health -= 2;
            }
            else if (Happiness <= 50)
            {
                Health -= 5;
            }
        }

        public void Flood()
        {
            CheckDeath();
            Money -= 10;
            Happiness -= 10;
            Health -= 10;
            AddDays(3);
            Console.WriteLine("You have " + Program.player.Money + " dollars remaining.");
            Console.WriteLine("You have " + Program.player.Happiness + " happiness remaining.");
            Console.WriteLine("You have " + Program.player.Health + " health remaining.");
            Console.WriteLine("You spent 3 days fixing your wagon." );
        }

        public void CheckStatus()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("You have these supplies at your disposal:");
            Console.WriteLine("You are at " + Program.player.Health + " health.");
            Console.WriteLine("You have " + Program.player.Money + " dollars.");
            Console.WriteLine("You have " + Program.player.Happiness + " happiness.");
            Console.WriteLine("You have " + Program.player.Food + " lbs of food.");
            Console.WriteLine("You have been traveling for " + Program.player.Days + " days.");
            Console.WriteLine("You have traveled " + Program.player.Miles + " miles in this state.");
            Console.WriteLine("*******************************************");
            Locations.Menu();
        }

        public void Continue()
        {
            AddMiles(25);
            NextDay();
        }

        public void BuyMeds()
        {
            Money -= 10;
            Health += 10;
        }

        public void CheckDeath()
        {
            if (Health <= 0)
            {
            Console.WriteLine("Sorry, " + Program.player.Name + ", you died.");
            Console.WriteLine(@"
                      ,____
                      |---.\
              ___     |    `
             / .-\  ./=)
            |  |'|_/\/|
            ;  |-;| /_|
           / \_| |/ \ |
          /      \/\( |
          |   /  |` ) |
          /   \ _/    |
         /--._/  \    |
         `/|)    |    /
           /     |   |
         .'      |   |
        /         \  |
       (_.-.__.__./  /

            
            ");
            Console.WriteLine("---------------------------");
            Program.Main();
            }
        }
    }
}