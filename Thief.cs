namespace Gotham
{
    public class Thief : Person
    {
        public Inventory Inventory = new Inventory();

        public Thief(int x, int y) : base(x, y)
        {
            Icon = 'T';
        }

        public void Steal(Citizen citizen)
        {
            if (citizen.Inventory.items.Count > 0)
            {
                int index = Random.Shared.Next(citizen.Inventory.items.Count);

                Things item = citizen.Inventory.items[index];

                Inventory.items.Add(item);

                citizen.Inventory.items.Remove(item);
            }
        }
    }
}
