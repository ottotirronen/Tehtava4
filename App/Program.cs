using System;
using AppLogger;
using Humanizer;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // humanisoidaan tekstiä
            string text = "PascalCaseText";
            Console.WriteLine(text.Humanize());

            // Humanisoidaan aika
            TimeSpan time = TimeSpan.FromDays(3);
            Console.WriteLine(time.Humanize());
            
        }
    }
}
