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
            if(string.IsNullOrEmpty(title) || title.Length > 100) // Jika judul video kosong atau lebih dari 100 karakter
            {
                throw new ArgumentException("Title must not be empty and must be less than 100 characters"); // Lempar pengecualian dengan pesan error
            }
            this.playCount = 0; // Tetapkan playCount ke 0
        }

        public void increasePlayCount(int playCount)
        {
            try 
            {
                checked 
                {
                    if (playCount < 0 || playCount > 10000000) 
                    {
                        throw new ArgumentException(playCount + " is not a valid play count. Play count must be between 0 and 10,000,000"); // Lempar pengecualian dengan pesan error
                    }
                    this.playCount += playCount; // Tambahkan playCount dengan jumlah yang diberikan
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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