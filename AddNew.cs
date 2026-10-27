using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Gotham
{
    internal class AddNew
    {
        static Random random = new Random();

        public static void Input(City city, int width, int height)
        {
            if (!Console.KeyAvailable)
            {
                return;
            }

            ConsoleKey key = Console.ReadKey(true).Key;
            int x = random.Next(0, width);
            int y = random.Next(0, height);

            switch (key)
            {
                case ConsoleKey.P:
                    city.People.Add(new Police(x, y));
                    //feeds.Add("En ny polis har flyttat in i staden!")
                    break;
                case ConsoleKey.T:
                    city.People.Add(new Thief(x, y));
                    //feeds.Add("En ny tjuv har flyttat in i staden!")
                    break;
                case ConsoleKey.C:
                    city.People.Add(new Citizen(x, y));
                    //feeds.Add("En ny medborgare har flyttat in i staden!")
                    break;
            }
        }
    }
}
