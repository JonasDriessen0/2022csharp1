using PropertyOpdracht1;
using System;

namespace PropertyOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Hond huisdier = new Hond("Rudy");

            huisdier.Naam = "magniet" ; ;//deze mag niet werken!
        }
    }
}