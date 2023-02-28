using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            twitchStream.name = "joons";
            twitchStream.lastStreamName = "MW2 gaming";
            twitchStream.streamGame = new Game("Modern warfare 2");
            twitchStream.followers = 23;
            twitchStream.automod = true;


            Console.WriteLine("Hello, World!");
        }
    }
}