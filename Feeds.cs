using System;
using System.Collections.Generic;
using System.Text;

namespace Gotham
{
    internal class Feeds
    {
        public int Height { get; set; }
        public int Width { get; set; }
       

        public Feeds(int height, int width)
        {
            Height = height;
            Width = width; 
        }
           
    }

    //change show method to show all händelse step by step 

    class StatusFeed : Feeds
    {
        public string Status { get; set; }
        public StatusFeed(int height, int width, string status) : base(height, width)
        {
            Status = status; 
        }

        public void show()
        {

            int x = 0;
            int y = 27;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("Status" + new string('=', Width - 4));

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(x, y + i + 1);

                Console.Write("|");
                Console.Write(new string(' ', Width));
                Console.Write("|");
            }

            Console.SetCursorPosition(x, y + Height + 1);
            Console.Write(new string('=', Width + 2));
        }
    }



    class NewsFeed : Feeds 
    {
        public List<string> News { get; set; }
        public NewsFeed(int height, int width, List<string> news) : base(height, width)
        {
            News = news; 
        }   

        public void Show(int x, int y)
        {

            //int x = 40;
            //int y = 27;

            Console.SetCursorPosition(x, y);
            Console.Write("NewsFeed" + new string('=', Width - 6));

            for (int row = 0; row < Height; row++)
            {

                int index = News.Count - 1 - row;
                string text = "";

                if (index>=0)
                {
                    text = News[index];
                }
                else if (News.Count == 0 && row == 0)
                {
                    text = "Inga nyheter";
                }
                Console.SetCursorPosition(x, y + row + 1);

                Console.Write("|");

                for (int column = 0; column < Width; column++)
                {
                    if(column < text.Length)
                    {
                        Console.Write(text[column]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                //Console.Write(new string(' ', Width));
                Console.Write("|");
            }

            Console.SetCursorPosition(x, y + Height + 1);
            Console.Write(new string('=', Width + 2));
        }
    }

    
}
