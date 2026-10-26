namespace Gotham
{
    public class Place
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Person> People { get; set; }

        public Place(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
            People = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        public void RemovePerson(Person person)
        {
            People.Remove(person);
        }

        public void Show()
        {
            char[,] grid = new char[Height, Width];

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    grid[y, x] = ' ';
                }
            }

            foreach (Person person in People)
            {
                if (person.X >= 0 && person.X < Width &&
                    person.Y >= 0 && person.Y < Height)
                {
                    grid[person.Y, person.X] = person.Icon;
                }
            }

            Console.ResetColor();
            Console.WriteLine(Name + " " + new string('=', Width));

            for (int y = 0; y < Height; y++)
            {
                Console.Write("|");

                for (int x = 0; x < Width; x++)
                {
                    char symbol = grid[y, x];

                    switch (symbol)
                    {
                        case 'C':
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 'P':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 'T':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        default:
                            Console.ResetColor();
                            break;
                    }

                    Console.Write(symbol);
                    Console.ResetColor();
                }

                Console.WriteLine("|");
            }

            Console.WriteLine(new string('=', Width + 2));
            Console.WriteLine($"People: {People.Count}");
        }
    }
}