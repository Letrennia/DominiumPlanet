using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Views
{
    internal class ReactionView
    {
        public static void NegativeReaction()
        {
            AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title($"[red]Nie możesz sfinansować tego przedsięwzięcia.[/]")
                .WrapAround()
                .AddChoices("Kontynuuj"));
        }
        public static void PositiveReaction()
        {
            AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title($"[green]Zrealizowano przedsięwzięcie.[/]")
                .WrapAround()
                .AddChoices("Kontynuuj"));
        }
    }
}
