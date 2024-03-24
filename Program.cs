// See https://aka.ms/new-console-template for more information
using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    // 
    public SayaTubeVideo(string title)
    {
        this.id = GenerateRandomID();
        this.title = title;
        this.playCount = 0;
    }

    // Method menambah jumlah playCount
    public void IncreasePlayCount(int countToAdd)
    {
        playCount += countToAdd;
    }
   
    // Method mencetak detail video
    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video Details:");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    // Method Menghasilkan ID acak
    private int GenerateRandomID()
    {
        Random random = new Random();
        return random.Next(10000, 99999); // 5 number random
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek SayaTubeVideo
        string judulVideo = "Tutorial Design By Contract - Bhintang";
        SayaTubeVideo video = new SayaTubeVideo(judulVideo);

        // Menambah jumlah playCount
        video.IncreasePlayCount(10);

        // Mencetak detail video
        video.PrintVideoDetails();
    }
}