using System;
using System.Collections.Generic;

namespace Game.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Money { get; set; }
        public int Hunger { get; set; }

        public Character(string name)
        {
            Name = name;
            Health = 100;
            Money = 0;
            Hunger = 100;
        }

    }
}