using System;
using System.Collections.Generic;
using System.Text;

namespace Escape_From_The_Castle
{
    public class Bag
    {
        private int MaxBagSize;
        private readonly List<Item> Contents = new List<Item>();

        public Bag(int size)
        {
            MaxBagSize = size;
        }

        public static void Describe(Bag sender)
        {
            Console.Write("I have the following items in my bag: ");
            foreach (Item i in sender.Contents)
            {
                Console.Write(Item.GetName(i) + " ");
            }
            Console.WriteLine();
        }

        public static void Add(Bag sender, Item i)
        {
            if (sender.Contents.Count < sender.MaxBagSize)
            {
                sender.Contents.Add(i);
            }
            else
            {
                throw new ArgumentException("The bag is already full", "original");
            }
        }

        public static void Use(Bag sender, Item i)
        {
            Console.WriteLine("Using " + Item.GetName(i));
            sender.Contents.Remove(i);
        }

        public static void DropIndex(Bag sender, int index)
        {
            sender.Contents.RemoveAt(index);
        }

        public static void SetSize(Bag sender, int new_size)
        {
            sender.MaxBagSize = new_size;
        }

        public static int GetLength(Bag sender)
        {
            return sender.Contents.Count;
        }

        public static Item GetItem(Bag sender, int index)
        {
            return sender.Contents[index];
        }
    }
}
