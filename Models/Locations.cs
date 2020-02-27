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
        if (playerEncounterRiver == "pay guide for secrets")
        {
            Program.player.PayMoney(10);
            Console.WriteLine("You now have " + Program.player.Money + " dollars remaining");
        } 
    }
        
    }




}