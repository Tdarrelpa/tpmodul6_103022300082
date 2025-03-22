// See https://aka.ms/new-console-template for more information
using cobaPutarVideo;

public class Program 
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract – Timotius Darrel");
        video1.increasePlayCount(10);
        video1.printVideoDetails();
    }
}