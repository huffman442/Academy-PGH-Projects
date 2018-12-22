using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album_Intake
{
    class Program
    {
        static void Main(string[] args)
        {
            Album firstAlbum = new Album();
            Album secondAlbum = new Album();
            firstAlbum.GetAlbum();
            secondAlbum.GetAlbum();

            firstAlbum.tracklist = new Song[firstAlbum.tracks];
            firstAlbum.GetSongs("first");

            secondAlbum.tracklist = new Song[firstAlbum.tracks];
            secondAlbum.GetSongs("second");

            firstAlbum.PrintAlbum();
            Console.WriteLine("Tracklist : ");
            for (int i = 0; i < firstAlbum.tracks; i++)
            {
                firstAlbum.tracklist[i].PrintSong();
            }

            secondAlbum.PrintAlbum();
            Console.WriteLine("Tracklist : ");
            for (int i = 0; i < secondAlbum.tracks; i++)
            {
                secondAlbum.tracklist[i].PrintSong();
            }

            Console.ReadLine();
        }
        static string GetUserInput(string whatToSayToUser)
        {
            Console.WriteLine(whatToSayToUser);
            string result = Console.ReadLine();
            return result;
        }
        static int GetUserNumber(string whatToSayToUser)
        {
            Console.WriteLine(whatToSayToUser);
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
    }
    public class Album
    {
        public string name;
        public string artist;
        public string genre;
        public int year;
        public int tracks;

        public Song[] tracklist;
        public void GetAlbum()
        {
            name = GetUserInput("What is the name of the album?");
            genre = GetUserInput("What genre is the album?");
            artist = GetUserInput("What artist made the album?");
            year = GetUserNumber("What year was the album made?");
            tracks = GetUserNumber("How many tracks are on the album?");
        }
        public void PrintAlbum()
        {
            Console.WriteLine();
            Console.WriteLine($"Album Name : {name}");
            Console.WriteLine($"Arist : {artist}");
            Console.WriteLine($"Genre : {genre}");
            Console.WriteLine($"Year : {year}");
            Console.WriteLine($"The Album has {tracks} tracks");

        }
        public void GetSongs(string albumNum)
        {
            for (int i = 0; i < tracks; i++)
            {
                tracklist[i] = new Song();
                tracklist[i].songName = GetUserInput($"What is track {i + 1} on {albumNum} album?");
                tracklist[i].length = GetUserInput($"How long is track {i + 1}");
            }
        }
        static string GetUserInput(string whatToSayToUser)
        {
            Console.WriteLine(whatToSayToUser);
            string result = Console.ReadLine();
            return result;
        }
        static int GetUserNumber(string whatToSayToUser)
        {
            Console.WriteLine(whatToSayToUser);
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
    }
    public class Song
    {
        public string songName;
        public string length;
        public void PrintSong()
        {
            Console.WriteLine();
            Console.WriteLine($"Track :  {songName} .........{length}");
        }
    }
}
