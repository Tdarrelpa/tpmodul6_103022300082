// See https://aka.ms/new-console-template for more information
using cobaPutarVideo;

public class Program 
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract – Timotius Darrel");
        for (int i = 0; i < 5; i++)
        {
            video1.increasePlayCount(3000000);
        }
        video1.printVideoDetails();
    }
}