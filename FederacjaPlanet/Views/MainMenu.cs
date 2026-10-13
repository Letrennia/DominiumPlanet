using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Views
{
    public class MainMenu
    {
        private readonly ConsoleView consoleView = new();

        public int ShowMenu()
        {
            return consoleView.Show("Main menu", new[]
            {
                "Raport",
                "Przeglad planet",
                "Przegladaj statystyki",
                "Decyzje",
                "Zakoncz ture",
                "Wyjscie"
            });

        }
    }
}
