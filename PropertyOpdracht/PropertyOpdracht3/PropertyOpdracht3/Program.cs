using System;
using System.ComponentModel.Design;

namespace PropertyOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Mens mens = new Mens(16);

            mens.Leeftijd++;//deze moet werken
            mens.Leeftijd--;//deze mag niet werken
        }
    }
}