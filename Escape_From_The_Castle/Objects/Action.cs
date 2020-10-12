using System;
using System.Collections.Generic;
using System.Text;

namespace Escape_From_The_Castle
{
    class Action
    {
        public Action(string name)
        {
            switch (name)
            {
                case "firebolt":
                    Type = "Attack";
                    Name = "firebolt";
                    Health = -20;
                    Range = 10;
                    break;
                default:
                    throw new ArgumentException("Type does not exist");
            }
        }
        public Action(string name, int damage)
        {

        }
        private string Type;
        private string Name;
        private int Health;
        private int Range;

        public static void Action_Option(Action sender)
        {
            switch (sender.Type)
            {
                case "Attack":
                    Console.WriteLine($"{sender.Name} - R:{sender.Range} D:{(sender.Health * -1)}");
                    break;
                default:
                    throw new ArgumentException("Type does not exist");
            }

        }
    }
}