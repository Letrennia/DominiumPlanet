using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using DominiumPlanet.Models;

namespace DominiumPlanet.Views
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
        public static void Riot(string planetName, int money)
        {
            AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title($"[red]Na {planetName} wybuchły zamieszki. Od tej pory dochód Skarbca będzie mniejszy o {money}. Jeśli nie zapanujesz nad sytuacją autorytet władzy centralnej będzie " +
                $"stopniowo malał.[/]")
                .WrapAround()
                .AddChoices("Kontynuuj"));
        }
        public static void RiotEnded(string planetName, int money)
        {
            AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title($"[green]Zamieszki na {planetName} chwilowo ustały. Dochód Skarbca zwiększy się o {money}.[/]") 
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

        public static void GameWon()
        {
            AnsiConsole.MarkupLine($"[green]Udało ci się przetrwać 9 cykli!.[/]");
            Console.ReadKey();
        }


        //GAME OVER
        public static void GameOverEmptyTreasure()
        {
            AnsiConsole.MarkupLine($"[red bold]GAME OVER.[/]");
            AnsiConsole.MarkupLine($"[red]Skarbiec nie może pozostać pusty.[/]");
            Console.ReadKey();
        }

        public static void GameOverDebt()
        {
            AnsiConsole.MarkupLine($"[red bold]GAME OVER.[/]");
            AnsiConsole.MarkupLine($"[red]Bankierzy wyczuli w tobie słabość. Zostałeś obalony. [/]");
            Console.ReadKey();
        }

        public static void GameOverIndependece(Planet planet)
        {
            AnsiConsole.MarkupLine($"[red bold]GAME OVER.[/]");
            AnsiConsole.MarkupLine($"[red]{planet.Name} odłączyło się od Sol Dominium. Twoja pozycja nie jest już respektowana. [/]");
            Console.ReadKey();
        }
    }
}
