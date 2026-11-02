namespace Gotham
{
    public class City : Place
    {
        public int RobberiesCount { get; set; }
        public int StolenThingsCount { get; set; }
        public int ArrestedThievesCount { get; set; }
        public Prison Prison { get; set; }
        public PoorHouse PoorHouse { get; set; }
        public int ReleasedThievesCount { get; private set; }

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
            ReleasePrisoners();
        }


        public void CheckMeeting()
        {
            foreach (var person in People.ToList())
            {
                foreach (var otherPerson in People.ToList())
                {
                    if (!People.Contains(person) || !People.Contains(otherPerson))
                        continue;

                    if (person == otherPerson ||
                        person.X != otherPerson.X ||
                        person.Y != otherPerson.Y)
                        continue;

                    // Thief meets Citizen
                    if (person is Thief thief &&
                        otherPerson is Citizen citizen)
                    {
                        Things? stolenItem = thief.Steal(citizen);

                        if (stolenItem != null)
                        {
                            RobberiesCount++;
                            StolenThingsCount++;

                            if (citizen.Inventory.items.Count == 0)
                            {
                                People.Remove(citizen);
                                PoorHouse.AcceptCitizen(citizen);
                            }
                        }
                    }

                    // Police meets Thief
                    else if (person is Police police &&
                             otherPerson is Thief caughtThief)
                    {
                        int confiscated = police.ArrestThief(caughtThief);

                        //ReturnedThingsCount += confiscated;
                        ArrestedThievesCount++;

                        caughtThief.ArrestTime = DateTime.Now;

                        People.Remove(caughtThief);
                        Prison.AddPrisoner(caughtThief);
                    }
                }
            }
        }

        public void ReleasePrisoners()
        {
            List<Thief> releasedThieves = Prison.ReleaseThieves();

            foreach (Thief thief in releasedThieves)
            {
                AddPerson(thief);

                ReleasedThievesCount++;
            }
        }

        public void ShowStatus()
        {

            Console.SetCursorPosition(2, 28);
            Console.Write($"Robberies: {RobberiesCount}       ");

            Console.SetCursorPosition(2, 29);
            Console.Write($"Arrested Thieves: {ArrestedThievesCount}       ");

            Console.SetCursorPosition(2, 30);
            Console.Write($"Stolen Things: {StolenThingsCount}       ");

            Console.SetCursorPosition(2, 31);
            Console.Write($"Released Thieves: {ReleasedThievesCount}       ");

            Console.SetCursorPosition(2, 32);
            Console.Write($"Citizens: {People.Count(p => p is Citizen)}       ");

            Console.SetCursorPosition(32, 28);
            Console.Write($"Police: {People.Count(p => p is Police)}       ");

            Console.SetCursorPosition(32, 29);
            Console.Write($"Thieves: {People.Count(p => p is Thief)}       ");
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
