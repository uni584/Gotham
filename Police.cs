namespace Gotham
{
    internal class Police : Person
    {
        public List<string> StolenItem { get; set; } = new List<string>();
        public Police(int x, int y) : base(x, y)
        {
            Icon = 'P';
        }

        public void Arrest(Thief thief, Prison prison, List<Person> city)
        {
           
            if ( StolenItem.Count > 0)
            {
                //Console.WriteLine("Du är arristerad");
                city.Remove(thief);
                prison.People.Add(thief);
            }
                

                    
        }
    }
}
