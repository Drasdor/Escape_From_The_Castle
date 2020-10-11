using System;
using System.Collections.Generic;
using System.Text;

namespace Escape_From_The_Castle
{
    public class Item
    {
        public Item(string name)
        {
            switch (name)
            {
                case "torch":
                    Name = "torch";
                    break;
                case "knife":
                    Name = "knife";
                    break;
                default:
                    throw new ArgumentException("Type does not exist");
            }
        }
        private string Name;

        public static string get_name(Item sender)
        {
            return sender.Name;
        }        
    }    
}
