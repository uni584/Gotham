using System;
using System.Collections.Generic;
using System.Text;

namespace Gotham
{
    internal class City
    {
        public int Width { get; }
        public int Hight { get; }

        public City(int width, int hight)
        {
            Width = width;
            Hight = hight;
        }

        public void Show() 
        {
            Console.WriteLine("City======================================================================================================");
            for (int s = 0; s < 20; s++)
            {

                Console.WriteLine("X                                                                                                        X");
                //for (int x = 0; x < 50; x++)
                //{


                //}

            }
            Console.WriteLine("Status====================================================================================================");
            for (int s = 0; s < 5; s++)
            {

                Console.WriteLine("X                                                                                                        X");
                //for (int x = 0; x < 50; x++)
                //{


                //}

            }
            Console.WriteLine("News======================================================================================================");
            for (int s = 0; s < 5; s++)
            {

                Console.WriteLine("X                                                                                                        X");
                //for (int x = 0; x < 50; x++)
                //{


                //}

            }
            Console.WriteLine("==========================================================================================================");

        }



    }
}
