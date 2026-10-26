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

        public Prison(int prisoners, int height, int width, List<Person> people)
            : base(height, width, people)
        {
            Prisoners = prisoners;
        }

        public void show()
        {
            int x = 103;
            int y = 1;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("Prison" + new string('=', Width - 4));

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(x, y + i + 1);

                Console.Write("|");

                for (int j = 0; j < Width; j++)
                {
                    Console.Write(".");
                }

                Console.WriteLine("|");
            }

            Console.SetCursorPosition(x, y + Height + 1);
            Console.WriteLine(new string('=', Width + 2));
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
            int x = 103;
            int y = 14;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("PoorHouse" + new string('=', Width - 7));

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(x, y + i + 1);

                Console.Write("|");

                for (int j = 0; j < Width; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("|");
            }

            Console.SetCursorPosition(x, y + Height + 1);
            Console.WriteLine(new string('=', Width + 2));
        }
    }
}


