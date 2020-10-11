using System;
using System.Collections.Generic;
using System.Text;

namespace Escape_From_The_Castle
{
    public class Bag
    {
        public Bag(int size)
        {
            max_bag_size = size;
        }

        private int max_bag_size;
        private List<Item> contents = new List<Item>();

        public static void describe(Bag sender)
        {
            Console.Write("I have the following items in my bag: ");
            foreach (Item i in sender.contents)
            {
                Console.Write(Item.get_name(i) + " ");
            }
            Console.WriteLine();
        }

        public static void add(Bag sender, Item i)
        {
            if (sender.contents.Count < sender.max_bag_size)
            {
                sender.contents.Add(i);
            }
            else
            {
                throw new ArgumentException("The bag is already full", "original");
            }
        }

        public static void use(Bag sender, Item i)
        {
            Console.WriteLine("Using " + Item.get_name(i));
            sender.contents.Remove(i);
        }

        public static void drop_index(Bag sender, int index)
        {
            sender.contents.RemoveAt(index);
        }

        public static void set_size(Bag sender, int new_size)
        {
            sender.max_bag_size = new_size;
        }

        public static int get_length(Bag sender)
        {
            return sender.contents.Count;
        }

        public static Item get_item(Bag sender, int index)
        {
            return sender.contents[index];
        }
    }
}
