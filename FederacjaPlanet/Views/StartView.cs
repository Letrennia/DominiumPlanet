using FederacjaPlanet.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Views
{
    internal class StartView
    {
        public void ShowStory()
        {
            GameModel gameModel = new GameModel();
            AnsiConsole.MarkupLine($"[magenta bold]{gameModel.Title}[/]\n");
            AnsiConsole.MarkupLine($"{gameModel.Story}\n");

            AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("")
                .WrapAround()
                .AddChoices("Kontynuuj"));

        }
    }
}
