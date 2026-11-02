namespace Gotham
{
    internal class Police : Person
    {
        public Police(int x, int y) : base(x, y)
        {
            Icon = 'P';
        }

        public int ArrestThief(Thief thief)
        {
            int count = thief.Inventory.items.Count;

            foreach (Things item in thief.Inventory.items)
            {
                Inventory.items.Add(item);
            }

            thief.Inventory.items.Clear();

            return count;
        }
    }
}
