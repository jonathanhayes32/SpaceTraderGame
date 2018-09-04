using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public static class Player 
    {

            
        //Player name
       private static string PlayerName = "";
        private static string Ship;
        //Print out Game title and over view
        public static void StartGame()
        {
            Console.WriteLine("Weclome to Space Trader Game!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Space has always been a mystery to man");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("We now have the opportunity to explore it");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Thanks to technological advancements you will be embarking on this journey");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("We need you to start our new trading system with other planets");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The question is will you be successful or will failure be at your door");
            Console.ReadKey();
            Console.Clear();
            NamePlayer();
        }
        static void NamePlayer()
        {
            // ask player for a name, and save it
            Console.WriteLine("Adventurer, what is your name");
            PlayerName = Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Welcome " + PlayerName);
            Console.ReadKey();
            Console.Clear();
        }   
        
    }
}
