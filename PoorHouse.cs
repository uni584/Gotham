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

            //citizen ska vara i poorhouse när thiefs stjäl allt från dom 
            //sen kommer citizen ut när polisen lämnar saker
            //namn till alla citizen 

            People.Add(citizen);
        }
    }
}