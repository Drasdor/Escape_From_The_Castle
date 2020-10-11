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
                case "Firebolt":
                    break;
                default:
                    throw new ArgumentException("Type does not exist");
            }
        }
        public Action (string name, int damage)
        {

        }
        private string Type;
        private string Name;
        private int Health;
    }
}
