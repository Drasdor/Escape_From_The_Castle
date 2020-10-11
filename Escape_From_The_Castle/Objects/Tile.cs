using System;
using System.Collections.Generic;
using System.Text;

namespace Escape_From_The_Castle
{
    public class Tile
    {
        public Tile(char bottom)
        {
            Base = bottom;
            if (bottom == 'C')
            {
                chest = new Bag(3);
            }
            else
            {
                chest = new Bag(1);
            }
        }

        private char Base;
        private Bag chest;

        public static char get_char(Tile sender)
        {
            if (sender.Base == '|')
            {
                return '|';
            }

            return sender.Base;
        }

        public static ConsoleColor get_colour(Tile sender)
        {
            char c = Tile.get_char(sender);
            switch (c)
            {
                case '|':
                    return ConsoleColor.White;
                case 'X':
                    return ConsoleColor.DarkGray;
                case 'C':
                    return ConsoleColor.Blue;
                case 'D':
                    return ConsoleColor.Cyan;
                default:
                    throw new ArgumentException("Type does not exist");
            }
        }
    }
}
