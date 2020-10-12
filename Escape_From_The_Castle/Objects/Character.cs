using System;
using System.Collections.Generic;
using System.Text;

namespace Escape_From_The_Castle
{
    public class Character
    {
        public Character(string name, int health, int size)
        {
            Name = name;
            Health = health;
            Max_Health = health;
            Max_Bag_Size = size;
            Bag.set_size(Backpack, size);
        }
        public Character(string type, string name)
        {
            switch (type)
            {
                case "human":
                    Name = name;
                    Health = 100;
                    Max_Health = 100;
                    Max_Bag_Size = 5;
                    Bag.set_size(Backpack, 5);
                    actions.Add(new Action("firebolt"));
                    break;
                default:
                    throw new ArgumentException("Type does not exist");
            }
        }

        private int Max_Bag_Size;
        private string Name;
        private int Health;
        private int Max_Health;
        private int[] Location = { 0, 0 };
        private Bag Backpack = new Bag(1);
        private Boolean Door = false;
        private List<Action> actions = new List<Action>();

        public static void modify_health(Character sender, int modifier)
        {
            sender.Health += modifier;

            if (sender.Health < 1)
            {
                sender.Health = 0;
                throw new ArgumentException("Character has died");
            }
            if (sender.Health > sender.Max_Health)
            {
                sender.Health = sender.Max_Health;
            }
        }

        public static int get_health(Character sender)
        {
            return sender.Health;
        }

        public static int get_max_health(Character sender)
        {
            return sender.Max_Health;
        }

        public static int get_x(Character sender)
        {
            return sender.Location[0];
        }

        public static int get_y(Character sender)
        {
            return sender.Location[1];
        }

        public static void speak(Character sender)
        {
            Console.WriteLine("My name is " + sender.Name);
        }

        public static void move(Character sender, int col, int row)
        {
            if (sender.Location[0] + col < 0 || sender.Location[0] + row < 0)
            {
                throw new ArgumentException($"Move ({col}, {row}) takes player outside of room!", "original");
            }

            sender.Location[0] = sender.Location[0] + col;
            sender.Location[1] = sender.Location[1] + row;
        }

        public static void add_to_bag(Character sender, Item i)
        {
            Bag.add(sender.Backpack, i);
        }

        public static void describe_backpack(Character sender)
        {
            Bag.describe(sender.Backpack);
        }

        public static void use_item(Character sender, Item i)
        {
            Bag.use(sender.Backpack, i);
        }

        public static void drop_index(Character sender, int index)
        {
            Bag.drop_index(sender.Backpack, index);
        }

        public static Item get_item(Character sender, int index)
        {
            return Bag.get_item(sender.Backpack, index);
        }

        public static Boolean on_door(Character sender)
        {
            return sender.Door;
        }

        public static void Action_Menu(Character sender)
        {
            do
            {
                try
                {
                    Console.WriteLine("1 - Attack   2 - Use Item");
                    Console.WriteLine("3 - Move     4 - End Turn");
                    string input = Console.ReadLine();
                foreach (Action a in sender.actions)
                    {
                        Action.Action_Option(a);
                    }
                }
                catch
                {

                }
            } while (true);
        }
    }
}
