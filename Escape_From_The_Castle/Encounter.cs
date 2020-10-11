using System;
using System.Collections.Generic;
using System.Text;

namespace Escape_From_The_Castle
{
    class Encounter
    {
        public Encounter(string name)
        {
            if (name == "entrance")
            {
                current_room = new Room("entrance");
            }            
        }

        public static void Run(Encounter sender, Team players)
        {
            do
            {
                int total = Character_Count(sender, players);
                for (int i = 0; i < total; i++)
                {
                    Turn(sender, i);
                }
            } while (true);
        }

        public static void Turn(Encounter sender, int index)
        {
            Room.draw_room(sender.current_room);
            
        }

        public static int Character_Count(Encounter sender, Team players)
        {
            return (Team.Get_Count(sender.enemies) + Team.Get_Count(players));
        }

        private Room current_room;
        private Team enemies = new Team("enemies");
    }
}
