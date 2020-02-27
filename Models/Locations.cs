using System;
using System.Collections.Generic;
using Game.Models;
using Game;

namespace Game.Models
{
    public class Locations
    {


        public static void EncounterRiver()
        {
            Console.WriteLine("Oh no! You have come across a large river bank. You must choose what your group does from here");
            Console.WriteLine("[cross] [pay guide for secrets] [float]");
            string playerEncounterRiver = Console.ReadLine();
            Random rnd = new Random();
            int risk = rnd.Next(1, 15);
            if (playerEncounterRiver == "pay guide for secrets")
            {
                Program.player.PayMoney(10);
                Console.WriteLine("You now have " + Program.player.Money + " dollars remaining");
            }
            else if (playerEncounterRiver == "cross")
            {
                if (risk <= 6)
                {
                    Console.WriteLine("Sorry y'all, your wagon flooded and you lost some supplies");
                    Console.WriteLine("Here is what you lost:");
                    Program.player.Flood();
                }
                else
                {
                    Console.WriteLine("You successfully crossed the river!");
                }
            }
            else if (playerEncounterRiver == "float")
            {
              if (risk <= 3)
              {
                Console.WriteLine("Oh no! You tipped your raft over. Everything is wet and you are unhappy.");
                Program.player.Flood();
              }
              else
              {
                Console.WriteLine("You successfully crossed the river!");
              }
            }
        }

    }




}