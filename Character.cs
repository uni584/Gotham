using System;
using System.Collections.Generic;
using System.Text;

namespace Gotham
{
    internal class Character
    {
        public char Icon { get; set; }
        public string Name { get; set; }
        public List<Item> Inventory { get; set; } = new List<Item>();

        public Characters(string name)
        {
            Name = name;
            Inventory = new List<Item>();
        }
    }
    class Hero : Characters
    {
        public int CountVillan { get; set; }

        public Hero(string name, int countvillan) : base(name)
        {
            CountVillan = CountVillan;
        }
    }
    class Villan : Characters
    {
        public int StolenThings { get; set; }

        public Villan(string name, int stolenthings) : base(name)
        {
            StolenThings = stolenthings;
        }
    }
    class Citizan : Characters
    {


        public Citizan(string name) : base(name)
        {
            Icon = 'C';
            Inventory.Add(new Item("Key"));
            Inventory.Add(new Item("Phone"));
            Inventory.Add(new Item("Money"));
            Inventory.Add(new Item("Watch"));
        }

    }

    class Item
    {
        public string Name { get; set; }
        public Item(string name)
        {
            Name = name;
        }
    }

    public class move
    {
        public int Bredd = 50;
        public int Höjd = 30;
        public int X { get; set; }
        public int Y { get; set; }
        public int XD { get; set; }
        public int YD { get; set; }

        //private static Random random = new Random();

        private
    }
}

