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

            City city = new City(100, 25, 50, 50, 50);
            StatusFeed statusfeed = new StatusFeed(5, 60, "");
            NewsFeed newsfeed = new NewsFeed(5, 55, "");

            Console.Clear();

            while (true)
            {
                city.Update();

                city.Show();
                city.Prison.Show();
                city.PoorHouse.Show();

                Console.SetCursorPosition(0, city.Height + 3);
                city.ShowStatus();
                statusfeed.show();

                Console.SetCursorPosition(0, city.Height + 10);
                newsfeed.Show();
                city.ShowStatus();

                AddNew.Input(city,100,25);

                Thread.Sleep(500);
            }
        }
    }
}

