using FederacjaPlanet.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Views
{
    public class DecisionDetailsView
    {
        private readonly ConsoleView consoleView = new();
        public int ShowDecisionDetails(Decision decision)
        {
            AnsiConsole.WriteLine($"{decision.Name}\n");
            AnsiConsole.WriteLine($"Opis: {decision.Description}\n\n");

            var table = new Table();
            table.AddColumn("Koszt");
            table.AddRow(decision.Cost.ToString());

            AnsiConsole.Write(table);

            string[] optionArray = {decision.option1, decision.option2 };

            return consoleView.Show("", false, optionArray);

        }
    }
}
