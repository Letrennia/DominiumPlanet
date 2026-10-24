using DominiumPlanet.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominiumPlanet.Views
{
    internal class StartView
    {
        public void ShowStory()
        {
            GameModel gameModel = new GameModel();
            AnsiConsole.MarkupLine($"[yellow bold]{gameModel.Title}[/]\n");
            AnsiConsole.MarkupLine($"{gameModel.Story}\n");
            AnsiConsole.MarkupLine($"{gameModel.Rules}\n");

            AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("")
                .WrapAround()
                .AddChoices("Kontynuuj"));

        }
    }
}
