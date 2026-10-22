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

        public Person(int cityWidth, int cityHeight)
        {


            X = cityWidth;  //slupar personens startposition 
            Y = cityHeight;

            int[,] Directions =
            {
                { -1, -1 }, // Vänster ner
                { -1,  1 }, // Vänster upp
                {  1, -1 }, // Höger ner
                {  1,  1 }, // Höger upp

                { -1,  0 }, // Vänster
                {  1,  0 }, // Höger
                {  0, -1 }, // Upp
                {  0,  1 }  // Ner
            };
            int randomDirection = random.Next(Directions.GetLength(0));

            XDirections = Directions[randomDirection, 0];
            YDirections = Directions[randomDirection, 1];
        }

        public void Move(int cityWidth, int cityHeight) // uppdatera som pacman
        {
            X += XDirections;
            Y += YDirections;

            if (X >= cityWidth)
            {
                X = 0;
            }
            else if (X < 0)
            {
                X = cityWidth - 1;
            }

            if (Y >= cityHeight)
            {
                Y = 0;
            }
            else if (Y < 0)
            {
                Y = cityHeight - 1;
            }

        }
    }
}