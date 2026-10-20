namespace Gotham
{
    internal class Citizien : Person
    {

        public List<Things> things = new List<Things>();

        public Citizien(int x, int y)
        {
            Icon = 'C';
            X = x;
            Y = y;
        }
    }
}

