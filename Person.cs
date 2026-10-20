namespace Gotham
{
    internal class Person
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Icon { get; set; }
        public int XDirections { get; set; }
        public int YDirections { get; set; }

        private static Random random = new Random();

        private static readonly (int X, int Y)[] Directions =
        {
            (-1,-1), // Vänster ner
            (-1, 1), // Vänster upp
            (1,-1), // Häger ner
            (1,1), // Höger Upp

            (-1, 0),  // vänster
            (1, 0),   // höger
            (0, -1),  // upp
            (0, 1),   // ner
            
        };

        public Person(int cityWidth, int cityHeight)
        {
            XDirections = random.Next(cityWidth);
            YDirections = random.Next(cityHeight);

            var direction = Directions[random.Next(Directions.Length)]; //slumpar en riktning 
            XDirections = direction.X;
            YDirections = direction.Y;
        }

        //public void move()


    }
}