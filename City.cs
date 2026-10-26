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

        public City(int width, int hight, int citizen, int police, int thief)
            : base("Gotham City", width, hight)
        {
            Prison = new Prison(20, 5);
            PoorHouse = new PoorHouse(20, 5);

            for (int i = 0; i < citizen; i++)
            {
                People.Add(new Citizen(
                    Random.Shared.Next(width),
                    Random.Shared.Next(hight)));
            }

            for (int i = 0; i < thief; i++)
            {
                People.Add(new Thief(
                    Random.Shared.Next(width),
                    Random.Shared.Next(hight)));
            }

            for (int i = 0; i < police; i++)
            {
                People.Add(new Police(
                    Random.Shared.Next(width),
                    Random.Shared.Next(hight)));
            }
        }

        public void MovePeople()
        {
            foreach (Person person in People)
            {
                person.Move(Width, Height);
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
                                var stolenItem = citizen.Inventory.items[0];

                                citizen.Inventory.items.Remove(stolenItem);
                                //thief.Inventory.items.Add(stolenItem);
                                if (stolenItem != null)
                                {
                                    continue;
                                }
                                RobberiesCount++;
                                StolenThingsCount++;
                            }
                        }
                        else if (person is Police police &&
                                 otherPerson is Thief caughtThief)
                        {
                            //person.Arrest(caughtThief);
                            ArrestedThievesCount++;
                            People.Remove(caughtThief);
                            Prison.AddPerson(caughtThief);
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
