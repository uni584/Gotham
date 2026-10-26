namespace Gotham
{
    public class Citizen : Person
    {
        public Inventory Inventory = new Inventory();


        public Citizen(int x, int y) : base(x, y)
        {
            Icon = 'C';


            Inventory.items.Add(new Things("Telefon"));
            Inventory.items.Add(new Things("Klocka"));
            Inventory.items.Add(new Things("Pengar"));
            Inventory.items.Add(new Things("Nycklar"));

        }

    }
}

