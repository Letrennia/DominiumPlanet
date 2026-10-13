using FederacjaPlanet.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace FederacjaPlanet.Views
{
    public class PlayerDetailsView
    {
        public void ShowPlayerDetails(GameState gameState)
        {
            //GameState gameState = new GameState();
            Console.Clear();
            Console.WriteLine("\n### STATYSTYKI GRACZA ###\n");
            Console.WriteLine($"Tura: {gameState.Turn}/12");
            Console.WriteLine($"Skarb: {gameState.Treasury}");
            Console.WriteLine($"Zadluzenie: {gameState.Dept}");

            Console.WriteLine("\nNacisnij dowolny przycisk by kontynuowac.");
            Console.ReadKey(true);
        }
    }
}
