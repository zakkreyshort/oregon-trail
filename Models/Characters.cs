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

        public Character()
        {
            Name = "";
            Health = 100;
            Money = 100;
            Hunger = 100;
            Happiness = 100;
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

        public void AddMoney(int money)
        {
            Money += money;
        }

        public void PayMoney(int money)
        {
            Money -= money;
        }

        public void NextDay()
        {
            Hunger -= 5;
        }

        public void Flood()
        {
            Money -= 10;
            Happiness -= 10;
            Console.WriteLine("You have " + Program.player.Money + " dollars remaining");
            Console.WriteLine("You have " + Program.player.Happiness + " happiness remaining");
        }

    }
}