using FederacjaPlanet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Views
{
    internal class StartMenu
    {
        private readonly ConsoleView consoleView = new();

        public int ShowMenu(GameState gameState)
        {
            return consoleView.Show("Aby wybrać opcję użyj strzałek góra dół. Aby zatwierdzić opcje wciśnij enter.", false, new[]
            {
                "Nowa gra",
                "Wczytaj gre",
                "Wyjdź",
            }, gameState);
        }
    }
}
