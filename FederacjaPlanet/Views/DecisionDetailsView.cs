using FederacjaPlanet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Views
{
    public class DecisionDetailsView
    {
        private readonly ConsoleView consoleView = new();
        public void ShowDecisionDetails(Decision decision)
        {
            //GameState gameState = new GameState();
            Console.Clear();
            Console.WriteLine($"\n### {decision.Name} ###\n");
            Console.WriteLine($"Opis: {decision.Description}");
            Console.WriteLine($"Koszt: {decision.Cost}\n");

            string[] optionArray = {decision.option1, decision.option2 };

            consoleView.Show("", optionArray);


            //Console.WriteLine("\nNacisnij dowolny przycisk by kontynuowac.");
            Console.ReadKey(true);
        }
    }
}
