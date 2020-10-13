﻿using System;
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
                    Description = "An item used to light up dark places";
                    Used = false;
                    break;
                case "knife":
                    Name = "knife";
                    Description = "A basic weapon that can also be used to eat food";
                    Used = false;
                    break;
                case "chicken":
                    Name = "chicken";
                    Description = "Some tasty chicken to eat and boost your health";
                    Used = false;
                    break;
                default:
                    throw new ArgumentException("Type does not exist");
            }
        }
        protected string Name;
        protected string Description;
        protected bool Used;

        public static string get_name(Item sender)
        {
            return sender.Name;
        }

        public static void describe(Item sender)
        {
            Console.WriteLine(sender.Description);
        }

        public static void use(Item sender)
        {
            if (sender.Used == true)
            {
                throw new ArgumentException("Item already used");
            }
            sender.Used = true;
        }

        public static bool is_used(Item sender)
        {
            return sender.Used;
        }
    }

    public class Food : Item
    {
        private int health;
        public Food(string name) : base(name)
        {
            switch (name)
            {
                case "Chicken":
                    health = 10;
                    break;
                default:
                    throw new ArgumentException("Type does not exist");
            }
        }

        public static void use(Food sender)
        {

        }
    }
}

/*Console.WriteLine(Item.get_name(torch));
            Item.describe(torch);
            Item.use(torch);
            Item.use(torch);
*/