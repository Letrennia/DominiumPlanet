using FederacjaPlanet.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Views
{
    internal class RaportDetailsView
    {
        public void ShowRaportDetails(List<(int, Decision)> raportList)
        {
            if (raportList.Count == 0)
            {
                AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Nie podjęto żadnych decyzji!")
                .WrapAround()
                .AddChoices("Kontynuuj"));
                return;
            }

            int whichTurn = -1;

            for (int i = 0; i < raportList.Count; i++)
            {
                if (whichTurn != raportList[i].Item1)
                {
                    whichTurn = raportList[i].Item1;
                    AnsiConsole.MarkupLine($"\n[bold yellow]TURA {whichTurn}[/]\n");
                }

                AnsiConsole.MarkupLine($"[yellow]-[/] {raportList[i].Item2.Name}   Koszt: {raportList[i].Item2.Cost}\n");
            }

            AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("")
                .WrapAround()
                .AddChoices("Kontynuuj"));
        }
    }
}
