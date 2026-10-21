using FederacjaPlanet.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
namespace FederacjaPlanet.Views
{
    public class ConsoleView()
    {
        private readonly PlayerStatisticsView playerStatisticsView = new();
        public int Show(string title, bool playerBar, string[] options, GameState gameState)
        {
            if (playerBar == true) playerStatisticsView.ShowPlayerDetails(gameState);
            string choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title($"[magenta]{title}[/]")
                .WrapAround()
                .AddChoices(options));

            return Array.IndexOf(options, choice);

        }

        public string ShowString(string title, bool playerBar, string[] options, GameState gameState)
        {
            if (playerBar == true) playerStatisticsView.ShowPlayerDetails(gameState);
            string choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title($"[magenta]{title}[/]")
                .WrapAround()
                .AddChoices(options));

            return choice;
        }
    }
}
