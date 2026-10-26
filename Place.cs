using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

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

        public void Update()
        {
            foreach (var person in People)
            {
                person.Move(Width, Height);
            }
            

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

            char[,] grid = new char[Height - 1, Width - 1];
            for (int s = 0; s < Height; s++)
            {
                bool hittad = false;
                foreach (var person in People)
                {
                    if (person.X == s && person.Y == s)
                    {
                        Console.Write(person.Icon);
                        hittad = true;
                        break;
                    }
                }
                if (!hittad) 
                {
                    Console.Write(' ');
                }
            }

            Console.WriteLine("Prison" + new string('=', Width));
            for (int i = 0; i < Height; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine("|");
            }

            Console.WriteLine(new string('=', Width + 8));


        }
    }


    class PoorHouse : Place
    {
        public int PeopleIn { get; set; }
        public PoorHouse(int peoplein, int height, int width, List<Person> people) : base(height, width, people)
        {
            PeopleIn = peoplein;
        }
        public void Show()
        {
            char[,] grid = new char[Height - 1, Width - 1 ];
            for (int s = 0; s < Height; s++)
            {
                bool hittad = false;
                foreach (var person in People)
                {
                    if (person.X == s && person.Y == s)
                    {
                        Console.Write(person.Icon);
                        hittad = true;
                        break;
                    }
                    if (!hittad)
                    {
                        Console.Write(' ');
                    }
                }
            }

            Console.WriteLine("PoorHouse" + new string('=', Width));
            for (int i = 0; i < Height; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine("|");
            }

            Console.WriteLine(new string('=', Width + 8));
        }
    }
}


