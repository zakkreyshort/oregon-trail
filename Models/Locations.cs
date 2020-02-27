using System;
using System.Collections.Generic;
using Game.Models;
using Game;

namespace Game.Models
{
    public class Locations
    {
        public static void Menu()
        {
            Console.WriteLine("what would you like to do next?");
            Console.WriteLine("[continue] [hunt] [rest] [check status]");
            string userAction = Console.ReadLine();
            userAction = userAction.ToLower();
            if (userAction == "continue")
            {
                Program.player.Continue();
            }
            else if (userAction == "hunt")
            {
                Program.player.Hunt();
            }
            else if (userAction == "rest")
            {
                Console.WriteLine("How many days would you like to rest?");
                string restDays = Console.ReadLine();
                int daysOfRest = int.Parse(restDays);
                Program.player.Rest(daysOfRest);
            }
            else if (userAction == "check status")
            {
                Program.player.CheckStatus();
            }
            else
            {
                Menu();
            }
            
        }
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
            else
            {
                Console.WriteLine("Excuse me, what?");
                EncounterRiver();
            }
            Menu();
        }
        public static void EncounterFort()
        {
            Console.WriteLine("You encountered a fort, where you can [buy] food, [sell] food, replenish [health], [continue], or [rest]");
            string userAtFort = Console.ReadLine();
            if (userAtFort == "buy")
            {
                Program.player.BuyFood();
                Console.WriteLine("You now have " + Program.player.Food + " lbs of food.");
                EncounterFort();
            }
            else if (userAtFort == "sell")
            {
                Program.player.SellFood();
                Console.WriteLine("You now have " + Program.player.Food + " lbs of food.");
                EncounterFort();
            }

            else if (userAtFort == "health")
            {
                Program.player.BuyMeds();
                Console.WriteLine("You now have " + Program.player.Health + " health.");
                EncounterFort();
            }
            else if (userAtFort == "rest")
            {
                Console.WriteLine("How many days would you like to rest?");
                string restDays = Console.ReadLine();
                int daysOfRest = int.Parse(restDays);
                Program.player.Rest(daysOfRest);
                EncounterFort();
            }
            else if (userAtFort == "continue")
            {
                Program.player.Continue();
                Console.WriteLine("The members of the fort wish you the best on your journey!");
            }
            Menu();
        }
        public static void PrintState(string state)
        {
        if (state == "Missouri")
        {
          Console.WriteLine(@"
           _                          _ 
          (_)                        (_)
 _ __ ___  _ ___ ___  ___  _   _ _ __ _ 
| '_ ` _ \| / __/ __|/ _ \| | | | '__| |
| | | | | | \__ \__ \ (_) | |_| | |  | |
|_| |_| |_|_|___/___/\___/ \__,_|_|  |_|
          ");
        }
        else if (state == "Kansas") 
        {
          Console.WriteLine(@"
 _                             
| |                            
| | ____ _ _ __  ___  __ _ ___ 
| |/ / _` | '_ \/ __|/ _` / __|
|   < (_| | | | \__ \ (_| \__ \
|_|\_\__,_|_| |_|___/\__,_|___/
                               
          ");
        }
        else if (state == "Nebraska") 
        {
          Console.WriteLine(@"
            _                   _         
           | |                 | |        
 _ __   ___| |__  _ __ __ _ ___| | ____ _ 
| '_ \ / _ \ '_ \| '__/ _` / __| |/ / _` |
| | | |  __/ |_) | | | (_| \__ \   < (_| |
|_| |_|\___|_.__/|_|  \__,_|___/_|\_\__,_|
                               
          ");
        }
        else if (state == "Colorado") 
        {
          Console.WriteLine(@"
           _                     _       
          | |                   | |      
  ___ ___ | | ___  _ __ __ _  __| | ___  
 / __/ _ \| |/ _ \| '__/ _` |/ _` |/ _ \ 
| (_| (_) | | (_) | | | (_| | (_| | (_) |
 \___\___/|_|\___/|_|  \__,_|\__,_|\___/ 
                               
          ");
        }
        else if (state == "Wyoming") 
        {
          Console.WriteLine(@"
                                _             
                               (_)            
__      ___   _  ___  _ __ ___  _ _ __   __ _ 
\ \ /\ / / | | |/ _ \| '_ ` _ \| | '_ \ / _` |
 \ V  V /| |_| | (_) | | | | | | | | | | (_| |
  \_/\_/  \__, |\___/|_| |_| |_|_|_| |_|\__, |
           __/ |                         __/ |
          |___/                         |___/ 
                               
          ");
        }
        else if (state == "Idaho") 
        {
          Console.WriteLine(@"
 _     _       _           
(_)   | |     | |          
 _  __| | __ _| |__   ___  
| |/ _` |/ _` | '_ \ / _ \ 
| | (_| | (_| | | | | (_) |
|_|\__,_|\__,_|_| |_|\___/ 
                           
          ");
        }
        else if (state == "Washington") 
        {
          Console.WriteLine(@"
                   _     _             _              
                  | |   (_)           | |             
__      ____ _ ___| |__  _ _ __   __ _| |_ ___  _ __  
\ \ /\ / / _` / __| '_ \| | '_ \ / _` | __/ _ \| '_ \ 
 \ V  V / (_| \__ \ | | | | | | | (_| | || (_) | | | |
  \_/\_/ \__,_|___/_| |_|_|_| |_|\__, |\__\___/|_| |_|
                                  __/ |               
                                 |___/  
          ");
        }
        else if (state == "Oregon") 
        {
          Console.WriteLine(@"
  ___  _ __ ___  __ _  ___  _ __  
 / _ \| '__/ _ \/ _` |/ _ \| '_ \ 
| (_) | | |  __/ (_| | (_) | | | |
 \___/|_|  \___|\__, |\___/|_| |_|
                 __/ |            
                |___/     
          ");
        }
        }
    }
}




