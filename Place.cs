using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace Gotham
{
    public class Place
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        

        public List<Person> People { get; set; }

        public Place(string name, int height, int width, int x, int y)
        {
            Name = name;
            Height = height;
            Width = width;
            X = x;
            Y = y;

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
            Console.ResetColor();

            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Name + " " +
                new string('=', Math.Max(0, Width - Name.Length)));

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y + i + 1);

                Console.Write("|");

                for (int j = 0; j < Width; j++)
                {
                    char symbol = '.';

                    foreach (Person person in People)
                    {
                        if (person.X == j && person.Y == i)
                        {
                            symbol = person.Icon;
                        }
                    }

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

                Console.Write("|");
            }

            Console.SetCursorPosition(X, Y + Height + 1);
            Console.WriteLine(new string('=', Width + 2));
        }
    }
}