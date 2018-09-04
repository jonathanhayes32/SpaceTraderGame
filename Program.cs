using System;
/*
 * Space Trader
 * by Team 7
 *  
 * This project is developing a Space trading game
 */
namespace SpaceGame
{
    class Program
    {

        static void Main(string[] args)
        {
            int money = 100;
            if (money <= 0)
            {
                Console.WriteLine("Good job, you lost.");
            }
            int fuel = 10;
            if (fuel <= 0)
            {
                Console.WriteLine("Who forgets to stop and get fuel?" +
                    " Obviously you loser.");
            }
            int cargo = 20;
            if (cargo < 20)
            {
                Console.WriteLine("Your ship needs to go on a diet. You lose. ");
            }
            int age = 40;
            if (age <= 0)
            {
                Console.WriteLine("Adventurer, you are to old to travel." +
                    " The nursing home is calling you name");
            }
            Player.StartGame();
            Console.WriteLine("you have " + money + " money");
            Console.ReadKey();
        }
    }
}
