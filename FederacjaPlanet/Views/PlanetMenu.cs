using DominiumPlanet.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominiumPlanet.Views
{
    public class PlanetMenu
    {
        private readonly ConsoleView consoleView = new();

        public int ShowMenu(GameState gameState)
        {
            return consoleView.Show("Wybierz planete", false, new[]
            {
                "Merkury",
                "Wenus",
                "Mars",
                "Ziemia",
                "Jowisz",
                "Sojusz Ksiezycowy",
                "Wyjdz"
            }, gameState);
        }
    }
}
