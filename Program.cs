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
            Thread.Sleep(1000);

            City city = new City(10, 5, 10, 20, 3);

            StatusFeed statusfeed = new StatusFeed(10, 90, "");

            NewsFeed newsfeed = new NewsFeed(10, 90, "");

            while (true)
            {
                city.Update();

                Console.Clear();

                city.Show();
                city.Prison.Show();
                city.PoorHouse.Show();
                city.ShowStatus();


                //statusfeed.show();
                //newsfeed.Show();

                Thread.Sleep(750); // Delay for 1 second
            }
        }
    }
}

