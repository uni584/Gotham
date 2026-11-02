namespace Gotham
{
    public class Prison : Place
    {
        public Prison(int height, int width, int x, int y)
            : base("Prison", height, width, x, y)
        {
        }

        public void AddPrisoner(Thief thief)
        {
            thief.X = Random.Shared.Next(Width);
            thief.Y = Random.Shared.Next(Height);

            AddPerson(thief);
        }

        public List<Thief> ReleaseThieves()
        {
            List<Thief> releasedThieves = new List<Thief>();

            foreach (Person person in People.ToList())
            {
                if (person is Thief thief &&
                    thief.ArrestTime != null &&
                    (DateTime.Now - thief.ArrestTime.Value).TotalSeconds >= 3)
                {
                    RemovePerson(thief);

                    thief.ArrestTime = null;

                    releasedThieves.Add(thief);
                }
            }

            return releasedThieves;
        }
    }
}
