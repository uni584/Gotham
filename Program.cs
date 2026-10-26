namespace Gotham
{
    internal class Program
    {
        static async Task Main(string[] args)

        {
            Console.WriteLine(@"           _==/          i     i          \==_");
            Console.WriteLine(@"         /XX/            |\___/|            \XX\");
            Console.WriteLine(@"       /XXXX\            |XXXXX|            /XXXX\");
            Console.WriteLine(@"      |XXXXXX\_         _XXXXXXX_         _/XXXXXX|");
            Console.WriteLine(@"     XXXXXXXXXXXxxxxxxxXXXXXXXXXXXxxxxxxxXXXXXXXXXXX");
            Console.WriteLine(@"    |XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX|");
            Console.WriteLine(@"    XXXXXXXXXX  WELCOME TO GOTHAM CITY  XXXXXXXXXXXXX");
            Console.WriteLine(@"    |XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX|");
            Console.WriteLine(@"     XXXXXX/^^^^""\XXXXXXXXXXXXXXXXXXXXX/^^^^^\XXXXXX");
            Console.WriteLine(@"      |XXX|       \XXX/^^\XXXXX/^^\XXX/       |XXX|");
            Console.WriteLine(@"        \XX\       \X/    \XXX/    \X/       /XX/");
            Console.WriteLine(@"            ""\       ""     \X/      ""       /""");


            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(2000);

            List<Person> people = new List<Person>();

            City city = new City(100, 25, 2, 2, 2);
            Prison prison = new Prison(0, 10, 15, people);

            List<Person> peoples = new List<Person>();
            PoorHouse poorhouse = new PoorHouse(0, 10, 15, people);

            StatusFeed statusfeed = new StatusFeed(5, 60, "");

            NewsFeed newsfeed = new NewsFeed(5, 55, "");

            while (true)
            {
                city.Update();
                city.Show();
                prison.show();
                poorhouse.Show();
                statusfeed.show();
                newsfeed.Show();

                Thread.Sleep(750); // Delay for 1 second
            }
        }
    }
}

