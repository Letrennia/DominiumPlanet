using FederacjaPlanet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Views
{
    internal class DecisionMenu
    {
        private readonly ConsoleView consoleView = new();
        private List<Decision> decisionList = DecisionCreator.CreateDecisionList();

        public int ShowMenu()
        {
            
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
            return consoleView.Show("Wybierz decyzje", activeDecisionArray);
        }
    }
}
