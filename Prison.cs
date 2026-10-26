namespace Gotham
{
    public class Prison : Place
    {
        public Prison(int height, int width)
            : base("Prison", height, width)
        {
        }

        public void ArrestThief(Thief thief)
        {
            AddPerson(thief);
        }
    }
}
