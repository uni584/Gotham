namespace Gotham
{
    public class PoorHouse : Place
    {
        public PoorHouse(int height, int width)
            : base("Poor House", height, width)
        {
        }

        public void AcceptCitizen(Citizen citizen)
        {
            AddPerson(citizen);
        }
    }
}
