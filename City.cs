namespace Gotham
{
    internal class City
    {
        public int Width { get; }
        public int Hight { get; }

        public int RobberiesCount { get; set; }
        public int ArrestedThievesCount { get; set; }
        public int StolenThingsCount { get; set; }
        public int ReturnedThingsCount { get; set; }
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
                    grid[s, i] = '.';
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
            Console.ResetColor();

            Console.WriteLine("City" + new string('=', Width - 2));
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
                    Console.ResetColor();
                }
                Console.WriteLine("|");
            }
            Console.WriteLine(new string('=', Width + 2));
            //Console.WriteLine("======================================================================================================");
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
            CheckMeeting();
        }

        public void CheckMeeting()
        {
            foreach (var person in people.ToList())
            {
                foreach (var otherPerson in people.ToList())
                {
                    if (!people.Contains(person) || !people.Contains(otherPerson))
                        continue;

                    if (person != otherPerson &&
                        person.X == otherPerson.X &&
                        person.Y == otherPerson.Y)
                    {
                        if (person is Thief thief &&
                            otherPerson is Citizen citizen)
                        {
                            if (citizen.Inventory.items.Count > 0)
                            {
                                thief.Steal(citizen);
                                RobberiesCount++;
                                StolenThingsCount++;

                            }
                        }
                        else if (person is Police police &&
                                 otherPerson is Thief caughtThief)
                        {
                            //person.Arrest(caughtThief);
                            ArrestedThievesCount++;
                            people.Remove(caughtThief);
                        }
                    }
                }
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Robberies: {RobberiesCount}");
            Console.WriteLine($"Arrested Thieves: {ArrestedThievesCount}");
            Console.WriteLine($"Stolen Things: {StolenThingsCount}");
            Console.WriteLine($"Returned Things: {ReturnedThingsCount}");
        }
    }
}
