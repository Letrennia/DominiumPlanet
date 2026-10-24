using DominiumPlanet.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominiumPlanet.Views
{
    internal class DecisionMenu
    {
        private readonly ConsoleView consoleView = new();

        public string ShowMenu(GameState gameState, List<Decision> decisionList)
        {
            AnsiConsole.Clear();
            List<string> activeDecisionList = new List<string>();
            for (int i = 0; i < decisionList.Count(); i++)
            {
                if (decisionList[i].IsActive == true)
                {
                    activeDecisionList.Add(decisionList[i].Name);
                }
            }
            activeDecisionList.Add("Wyjdz");

            string[] activeDecisionArray = activeDecisionList.ToArray();
            return consoleView.ShowString("Wybierz decyzje", true, activeDecisionArray, gameState);
        }
    }
}
