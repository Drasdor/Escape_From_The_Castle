using System;
using System.Collections.Generic;
using System.Text;

namespace Escape_From_The_Castle
{
    public class Team
    {
        public Team(string name)
        {
            Name = name;
        }
        private List<Character> Members = new List<Character>();
        private string Name;
        private int Health;

        public static void add_character(Team sender, string name, string type)
        {
            Character c = new Character(type, name);
            sender.Members.Add(c);
            sender.Health += Character.get_health(c);
        }

        public static void speak(Team sender, int index)
        {
            Character.speak(sender.Members[index]);
        }

        public static void get_health(Team sender, int index)
        {
            Character.get_health(sender.Members[index]);
        }

        public static void get_x(Team sender, int index)
        {
            Character.get_x(sender.Members[index]);
        }

        public static void get_y(Team sender, int index)
        {
            Character.get_y(sender.Members[index]);
        }

        public static void move(Team sender, int index, int col, int row)
        {
            Character.move(sender.Members[index], col, row);
        }

        public static void add_to_bag(Team sender, int index, Item i)
        {
            Character.add_to_bag(sender.Members[index], i);
        }

        public static void describe(Team sender, int index)
        {
            Character.describe_backpack(sender.Members[index]);
        }

        public static void use_item(Team sender, int index, Item i)
        {
            Character.use_item(sender.Members[index], i);
        }

        public static void modify_health(Team sender, int index, int change)
        {
            int health = Character.get_health(sender.Members[index]);
            int max_health = Character.get_max_health(sender.Members[index]);

            //Picks the appropriate change of health (accounting for max and 0)
            if (health + change < 1)
            {
                sender.Health -= health;
            }
            else if (health + change > max_health)
            {
                sender.Health += (max_health - health);
            }
            else
            {
                sender.Health += change;
            }

            Character.modify_health(sender.Members[index], change);
        }

        public static void transfer(Team sender, int from_player, int to_player, int index)
        {
            Character.add_to_bag(sender.Members[to_player], Character.get_item(sender.Members[from_player], index));
            Character.drop_index(sender.Members[from_player], index);
        }

        public static Boolean can_leave(Team sender)
        {
            foreach (Character c in sender.Members)
            {
                if (Character.on_door(c) == false)
                {
                    return false;
                }
            }
            return true;
        }

        public static Character get_character(Team sender, int index)
        {
            return sender.Members[index];
        }

        public static Boolean is_alive(Team sender)
        {
            if (sender.Health < 1)
            {
                return false;
            }
            return true;
        }

        public static int Get_Count(Team sender)
        {
            return sender.Members.Count;
        }
    }
}

/*Team.speak(players, 0);
Team.describe(players, 0);
Team.add_to_bag(players, 0, torch);
Team.use_item(players, 0, knife);
Team.move(players, 0, 3, 3);*/