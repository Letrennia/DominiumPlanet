using Spectre.Console;
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
            AnsiConsole.Clear();
            //AnsiConsole.Cursor.SetPosition(0, 0);

            return consoleView.Show("Main menu", true, new[]
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
