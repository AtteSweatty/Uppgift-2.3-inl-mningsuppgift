using System;

namespace Atte
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int startavgift = 300;

            
            int kostnadPerKilometer = 1;

            
            int kostnadPerExtraDag = 500;

            
            Console.Write("Hur många dagar vill du hyra bilen? ");
            int antalDagar = int.Parse(Console.ReadLine());

            
            Console.Write("Hur många kilometer ska du köra? ");
            double antalKilometer = double.Parse(Console.ReadLine());

            
            int totalHyra = startavgift + (antalDagar - 1) * kostnadPerExtraDag + (int)(antalKilometer * kostnadPerKilometer);

            
            Console.WriteLine($"Den totala hyran blir: {totalHyra} kr");
        }
    }
}