using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300050
{
    internal class SayaTubeVideo
    {
        private int id;
        public string title;
        public int playCount;



        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length <= 200 && title.Length > 0);
            
            this.title = title;
            this.id = new Random().Next(10000,99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000 && playCount >= 0);
            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play count: " + this.playCount);
        }
    }
}
