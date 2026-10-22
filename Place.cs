using Gotham;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Gotham
{
    internal class Place
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Person> People { get; set; } = new List<Person>();
        public Place(int height, int width, List<Person> people)
        {
            Height = height;
            Width = width;
            People = people;
        }

    }
    class Prison : Place
    {
        public int Prisoners { get; set; }
        public Prison(int prisoners, int height, int width, List<Person> people) : base(height, width, people)
        {
            Prisoners = prisoners;
        } 
        public void show()
        {

            char[,] grid = new char[Height, Width];
            for (int s = 0; s < Height; s++)
            {
                for (int i = 0; i < Width; i++)
                {
                    grid[s, i] = '.';
                }
            }
            Console.WriteLine("Prison" + new string ('=', Width));
            for (int i = 0; i < Height; i++)
            {
                Console.WriteLine("|");
            }
        }
     }

       
        class PoorHouse : Place
        {
            public int PeopleIn { get; set; }
            public PoorHouse(int peoplein, int height, int width, List<Person> people) : base(height, width, people)
            {
                PeopleIn = peoplein;
            }

        }

    }

    
