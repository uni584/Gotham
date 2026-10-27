namespace Gotham
{
    public class Person
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Icon { get; set; }
        public int XDirections { get; set; }
        public int YDirections { get; set; }
        public string Name { get; set; }

        private static Random random = new Random();

        public Person(int cityWidth, int cityHeight)
        {


            X = cityWidth;  //slupar personens startposition 
            Y = cityHeight;

            string[] names =
            {
                "Taen", "Jonas", "Amjad", "Lucas",
                "Adam", "Alexander", "Andreas", "Anton", "Benjamin",
                "Daniel", "David", "Elias", "Emil", "Erik",
                "Felix", "Filip", "Fredrik", "Gabriel", "Gustav",
                "Hampus", "Henrik", "Hugo", "Isak", "Jacob",
                "Johan", "Jonathan", "Josef", "Kevin", "Leo",
                "Leon", "Liam", "Linus", "Lucas", "Ludvig",
                "Marcus", "Martin", "Max", "Melvin", "Michael",
                "Mohammed", "Nils", "Noah", "Oliver", "Oscar",
                "Oskar", "Patrik", "Philip", "Rasmus", "Robin",
                "Samuel", "Sebastian", "Simon", "Theo", "William",

                "Alice", "Alma", "Amanda", "Amelia", "Anna",
                "Astrid", "Bella", "Caroline", "Cecilia", "Clara",
                "Ebba", "Elin", "Ella", "Ellen", "Elsa",
                "Emma", "Emilia", "Estelle", "Evelina", "Felicia",
                "Freja", "Hanna", "Ida", "Isabella", "Julia",
                "Klara", "Lina", "Lisa", "Liv", "Louise",
                "Maja", "Maria", "Matilda", "Moa", "Molly",
                "Nathalie", "Nora", "Olivia", "Rebecca", "Ronja",
                "Saga", "Sandra", "Sara", "Selma", "Sofia",
                "Stella", "Tilda", "Tindra", "Vera", "Wilma"
            };

            Name = names[Random.Shared.Next(names.Length)];

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