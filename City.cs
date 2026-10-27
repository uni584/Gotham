namespace Gotham
{
    public class City : Place
    {
        public int RobberiesCount { get; set; }
        public int StolenThingsCount { get; set; }
        public int ReturnedThingsCount { get; set; }
        public int ArrestedThievesCount { get; set; }
        public Prison Prison { get; set; }
        public PoorHouse PoorHouse { get; set; }

        public List<string> News { get; set; } = new List<string>();

        public City(int width, int height, int citizen, int police, int thief)
            : base("Gotham City", height, width, 0, 0)
        {
            Prison = new Prison(5, 20, width + 3, 0);
            PoorHouse = new PoorHouse(5, 20, width + 3, 8);

            for (int i = 0; i < citizen; i++)
            {
                People.Add(new Citizen(
                    Random.Shared.Next(width),
                    Random.Shared.Next(height)));
            }

            for (int i = 0; i < thief; i++)
            {
                People.Add(new Thief(
                    Random.Shared.Next(width),
                    Random.Shared.Next(height)));
            }

            for (int i = 0; i < police; i++)
            {
                People.Add(new Police(
                    Random.Shared.Next(width),
                    Random.Shared.Next(height)));
            }
        }

        public void Update()
        {
            foreach (var person in People)
            {
                person.Move(Width, Height);
            }
            CheckMeeting();

        }

        

        public void CheckMeeting()
        {
            foreach (var person in People.ToList())
            {
                foreach (var otherPerson in People.ToList())
                {
                    if (!People.Contains(person) || !People.Contains(otherPerson))
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

                                AddNews($" Tjuven ({thief}, {citizen}).");

                            }
                        }
                        else if (person is Police police &&
                                 otherPerson is Thief caughtThief)
                        {
                            Prison.ArrestThief(caughtThief);
                            ArrestedThievesCount++;
                            People.Remove(caughtThief);
                            //Prison.AddPerson(caughtThief);
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


        public void AddNews(string message)
        {
            News.Add(message);

            if (News.Count > 5)
            {
                News.RemoveAt(0);
            }
        }
    }
}
