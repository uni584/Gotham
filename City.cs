using System;
using System.Collections.Generic;
using System.Text;

namespace Gotham
{
    internal class City
    {
        public int Width { get; }
        public int Hight { get; }
        private List<Person> people = new List<Person>();
        public City(int width, int hight, int citizen, int police, int thief)
        {
            Width = width;
            Hight = hight;

            for(int i = 0; i < citizen; i++) people.Add(new Citizen(Random.Shared.Next(width), Random.Shared.Next(hight)));
            for (int i = 0; i < thief; i++) people.Add(new Thief(Random.Shared.Next(width), Random.Shared.Next(hight)));
            for (int i = 0; i < police; i++) people.Add(new Police(Random.Shared.Next(width), Random.Shared.Next(hight)));

        }

        public void Show() 
        {

            char[,] grid = new char[Hight, Width];

            Console.WriteLine("City======================================================================================================");
            for (int s = 0; s < Hight; s++)
            {
                Console.Write("X");

                for(int i = 0; i < Width; i++)
                {
                    //char symbol = grid[s, i];
                    Console.Write(".");
                     
                }
                Console.WriteLine("X");
            }
            Console.WriteLine("Status====================================================================================================");
            for (int s = 0; s < 5; s++)
            {

                Console.WriteLine("X                                                                                                        X");
                

            }
            Console.WriteLine("News======================================================================================================");
            for (int s = 0; s < 5; s++)
            {

                Console.WriteLine("X                                                                                                        X");
                

            }
            Console.WriteLine("==========================================================================================================");

        }



    }
}
