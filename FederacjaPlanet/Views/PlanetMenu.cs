using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Views
{
    public class PlanetMenu
    {
        private readonly ConsoleView consoleView = new();

        public int ShowMenu()
        {
            //AnsiConsole.Clear();
            return consoleView.Show("Wybierz planete", false, new[]
            {
                "Merkury",
                "Wenus",
                "Mars",
                "Ziemia",
                "Jowisz",
                "Sojusz Ksiezycowy",
                "Wyjdz"
            });
        }
    }
}
