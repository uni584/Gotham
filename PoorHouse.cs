namespace Gotham
{
    public class PoorHouse : Place
    {
        public PoorHouse(int height, int width, int x, int y)
            : base("Poor House", height, width, x, y)
        {
        }

        public void AcceptCitizen(Citizen citizen)
        {
            //citizen.X = Random.Shared.Next(Width);
            //citizen.Y = Random.Shared.Next(Height);

            People.Add(citizen);
        }
    }
}