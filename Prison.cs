namespace Gotham
{
    public class Prison : Place
    {
        public Prison(int height, int width, int x, int y)
            : base("Prison", height, width, x, y)
        {
        }

        public void ArrestThief(Thief thief)
        {
            thief.X = Random.Shared.Next(Width);
            thief.Y = Random.Shared.Next(Height);

            People.Add(thief);
        }
    }
}