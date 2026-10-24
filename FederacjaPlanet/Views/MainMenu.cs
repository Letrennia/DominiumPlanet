using DominiumPlanet.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominiumPlanet.Views
{
    public class MainMenu
    {
        private readonly ConsoleView consoleView = new();

        public int ShowMenu(GameState gameState)
        {
            AnsiConsole.Clear();

            return consoleView.Show("Main menu", true, new[]
            {
                "Raport",
                "Przeglad planet",
                "Przegladaj statystyki",
                "Decyzje",
                "Zakoncz ture",
                "Zapisz gre",
                //"Wczytaj gre",
                "Wyjscie"
            }, gameState);

        }
    }
}
