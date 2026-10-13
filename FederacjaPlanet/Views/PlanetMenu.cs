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
            return consoleView.Show("Wybierz planete", new[]
            {
                "Merkury",
                "Wenus",
                "Mars",
                "Ziemia",
                "Jowisz",
                "Saturn Uran Neptun",
                "Wyjdz"
            });
        }
    }
}
