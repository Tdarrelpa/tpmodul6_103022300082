﻿using System.Diagnostics.Contracts;

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

            Contract.Requires(!string.IsNullOrEmpty(title), "Title must not be empty."); // Pastikan judul tidak kosong
            Contract.Requires(title.Length <= 100, "Title must be less than or equal to 100 characters."); // Pastikan judul tidak lebih dari 100 karakter

            this.playCount = 0; // Tetapkan playCount ke 0
        }

        public void IncreasePlayCount(int playCount)
        {
            try 
            {
                checked 
                {
                    if (this.playCount < 0 || this.playCount > 10000000) // Tujuan dari if-else ini bukan melacak playCount input (variable lokal method) melainkan output jumlah playCount (attribute class)
                    {
                        throw new ArgumentException(this.playCount + " is not a valid play count. Play count must be between 0 and 10,000,000"); // Lempar pengecualian dengan pesan error (attribute class, bukan variabel lokal)
                    }
                    this.playCount += playCount; // Tambahkan playCount dengan jumlah yang diberikan
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                this.playCount = 0; // Tetapkan playCount ke 0 jika terjadi error
            }
        }

        public void PrintVideoDetails()
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