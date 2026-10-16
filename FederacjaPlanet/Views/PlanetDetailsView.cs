using FederacjaPlanet.Models;
using Spectre.Console;
namespace FederacjaPlanet.Views
{
    internal class PlanetDetailsView
    {
        public void ShowPlanetDetails(Planet planet)
        {
            AnsiConsole.MarkupLine($"[magenta bold] {planet.Name} [/]\n");
            AnsiConsole.WriteLine($"\n{planet.Description}\n");

            if (planet.IsIndependent == false) AnsiConsole.MarkupLine("[bold] Planeta [green]nalezy[/] do Federacji[/]");
            else AnsiConsole.MarkupLine("[bold]Planeta [red]NIE [/]nalezy do Federacji[/]");


            string drink = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("")
                .AddChoices("wyjdz"));
        }
    }
}
