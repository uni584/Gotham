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



    class StatusFeed : Feeds
    {
        public string Status { get; set; }
        public StatusFeed(int height, int width, string status) : base(height, width)
        {
            Status = status; 
        }

        public void show()
        {

            Console.WriteLine("Status" + new string('=', Width));
            for (int i = 0; i < Height; i++)
            {
                Console.WriteLine("|" + new string(' ', Width + 6) + '|');

            }
        }
    }



    class NewsFeed : Feeds 
    {
        public string News { get; set; }
        public NewsFeed(int height, int width, string news) : base(height, width)
        {
            News = news; 
        }   

        public void Show()
        {

                Console.WriteLine("NewsFeed" + new string ('=', Width));
                for (int i = 0; i<Height; i++)
                {
                    Console.WriteLine("|" + new string (' ', Width + 6) + '|' );
               
                }
}
    }

    
}
