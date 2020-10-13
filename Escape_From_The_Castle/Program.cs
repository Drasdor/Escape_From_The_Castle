using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Escape_From_The_Castle
{
    class Program
    {
        static void Main()
        {
            Item torch = new Item("torch");
            Item knife = new Item("knife");
            int playerNumber = 0;
            string teamName = "";

            Console.WriteLine("Please enter a team name");
            teamName = Console.ReadLine();

            do
            {
                try
                {
                    Console.WriteLine("How many people are playing (between 1 and 4)?");
                    playerNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a whole number.");
                }
            } while (playerNumber > 4 || playerNumber < 1);



            Team players = new Team(teamName);

            for (int i = 0; i < playerNumber; i++)
            {
                Console.WriteLine($"What is the name of player {i + 1}?");
                string name = Console.ReadLine();
                Team.AddCharacter(players, name, "human");
                Team.AddToBag(players, i, torch);
                Team.AddToBag(players, i, knife);
            }

            Encounter entrance = new Encounter("entrance");
            Encounter.Run(entrance, players);

            Console.ReadLine();
        }
    }
}