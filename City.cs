namespace Gotham
{
    internal class City
    {
        public int Width { get; }
        public int Hight { get; }
        private List<Person> people = new List<Person>();
        public City(int width, int hight, int citizen, int police, int thief)
        {
            Width = width;
            Hight = hight;

            for (int i = 0; i < citizen; i++)
            {
                people.Add(new Citizen(Random.Shared.Next(width), Random.Shared.Next(hight)));
            }
            for (int i = 0; i < thief; i++)
            {
                people.Add(new Thief(Random.Shared.Next(width), Random.Shared.Next(hight)));
            }
            for (int i = 0; i < police; i++)
            {
                people.Add(new Police(Random.Shared.Next(width), Random.Shared.Next(hight)));
            }
        }

        public void Show()
        {

            char[,] grid = new char[Hight, Width];
            for (int s = 0; s < Hight; s++)
            {
                for (int i = 0; i < Width; i++)
                {
                    grid[s, i] = ' ';
                }
            }

            foreach (var person in people)
            {
                char current = grid[person.Y, person.X];
                if (current != 'P' || person.Icon == 'P')
                {
                    grid[person.Y, person.X] = person.Icon;
                }
            }
            Console.Clear();
            Console.WriteLine("City==================================================================================================");
            for (int s = 0; s < Hight; s++)
            {
                Console.Write("|");

                for (int i = 0; i < Width; i++)
                {
                    char symbol = grid[s, i];
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
                        case 'X':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        default:
                            Console.ResetColor();
                            break;
                    }
                    Console.Write(symbol);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("======================================================================================================");
            //Console.WriteLine("Status====================================================================================================");
            //for (int s = 0; s < 5; s++)
            //{

            //    Console.WriteLine("X                                                                                                        X");


            //}
            //Console.WriteLine("News======================================================================================================");
            //for (int s = 0; s < 5; s++)
            //{

            //    Console.WriteLine("X                                                                                                        X");


            //}
            //Console.WriteLine("==========================================================================================================");
        }

        public void Update()
        {
            foreach (var person in people)
            {
                person.Move(Width, Hight);
            }
        }
    }
}
