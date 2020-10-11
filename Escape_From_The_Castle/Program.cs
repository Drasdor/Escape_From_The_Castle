using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Data;

namespace Escape_From_The_Castle
{
    class Program
    {
        static void Main()
        {
            Item torch = new Item("torch");
            Item knife = new Item("knife");
            int player_number = 0;
            string team_name = "";

            Console.WriteLine("Please enter a team name");
            team_name = Console.ReadLine();

            do
            {
                try
                {
                    Console.WriteLine("How many people are playing (between 1 and 4)?");
                    player_number = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a whole number.");
                }
            } while (player_number > 4 || player_number < 1);



            Team players = new Team(team_name);

            for (int i = 0; i < player_number; i++)
            {
                Console.WriteLine($"What is the name of player {i + 1}?");
                string name = Console.ReadLine();
                Team.add_character(players, name, "human");
                Team.add_to_bag(players, i, torch);
                Team.add_to_bag(players, i, knife);
            }

            Encounter entrance = new Encounter("entrance");
            Encounter.Run(entrance);

            Console.ReadLine();
        }
    }
}