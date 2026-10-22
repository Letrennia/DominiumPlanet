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
                .AddChoices("Wróć"));
        }
        public static void PositiveReaction()
        {
            AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title($"[green]Zrealizowano przedsięwzięcie.[/]")
                .WrapAround()
                .AddChoices("Kontynuuj"));
        }

        public static void NegativeSave(Exception ex)
        {
            AnsiConsole.MarkupLine($"[red]Nie udało się zapisać gry.[/]\n {ex.Message}");
            Console.ReadKey();
        }
        public static void PositiveSave()
        {
            AnsiConsole.MarkupLine($"[green]Poprawnie zapisano stan gry.[/]");
            Console.ReadKey();
        }

        public static void NegativeRead(Exception ex)
        {
            AnsiConsole.MarkupLine($"[red]Nie udało się wczytać gry.[/]\n {ex.Message}");
            Console.ReadKey();
        }
        public static void PositiveRead()
        {
            AnsiConsole.MarkupLine($"[green]Poprawnie wczytano stan gry.[/]");
            Console.ReadKey();
        }
    }
}
