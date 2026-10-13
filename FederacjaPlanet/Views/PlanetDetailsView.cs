using System;
using System.Collections.Generic;
using System.Text;
using FederacjaPlanet.Models;
namespace FederacjaPlanet.Views
{
    internal class PlanetDetailsView
    {
        public void ShowPlanetDetails(Planet planet)
        {
            Console.Clear();
            Console.WriteLine($"### {planet.Name} ###");
            Console.WriteLine($"\n{planet.Description}\n");
            Console.WriteLine($"Budzet: {planet.Budget}");
            Console.WriteLine($"Zywnosc: {planet.Food}");
            Console.WriteLine($"Energia: {planet.Energy}");
            Console.WriteLine($"Zadowolenie spoleczne: {planet.PublicSatisfaction}");
            Console.WriteLine($"Autorytet wladzy: {planet.Authority}");

            Console.WriteLine($"\nProdukcja zywnosci (co ture): {planet.EnergyProduction}");
            Console.WriteLine($"Produkcja energii (co ture): {planet.EnergyProduction}");

            if (planet.IsIndependent == false) Console.WriteLine("Planeta nalezy do Federacji");
            else Console.WriteLine("Planeta NIE nalezy do Federacji");

            Console.WriteLine("\nNacisnij dowolny przycisk by kontynuowac.");

            Console.ReadKey(true);

        }
    }
}
