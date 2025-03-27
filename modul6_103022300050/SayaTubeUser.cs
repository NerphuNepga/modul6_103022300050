using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300050
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public String Username;

        public SayaTubeUser(string username)
        {
            this.Username = username;
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int jumlah = 0;
            for (int i = 0; i < uploadedVideos.Count; i++) 
            {
                jumlah += uploadedVideos[i].playCount;
            }
            return jumlah;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + this.Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.Write("Video " + (i+1) + " judul: " + uploadedVideos[i].title);    
                Console.WriteLine();
            }
        }
    }
}
