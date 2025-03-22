using System;

namespace cobaPutarVideo 
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rnd = new Random(); // Membuat objek random baru untuk menghasilkan angka acak
            this.id = rnd.Next(00000, 99999); // Buat nomor acak antara 00000 dan 99999 secara otomatis (inlkusif)
            this.title = title;
            this.playCount = 0; // Tetapkan playCount ke 0
        }

        public void increasePlayCount(int playCount)
        {
            this.playCount += playCount; // Tambahkan playCount dengan jumlah yang diberikan
        }

        public void printVideoDetails()
        {
            //Console.WriteLine("Video ID: " + this.id); <- Cetak ID video
            Console.WriteLine($"Video ID: {id}");
            //Console.WriteLine("Title: " + this.title); <- Cetak judul video
            Console.WriteLine($"Title: {title}");
            //Console.WriteLine("Play Count: " + this.playCount); <- Cetak jumlah pemutaran
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}