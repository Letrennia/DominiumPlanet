using DominiumPlanet.Models;
using Spectre.Console;
namespace DominiumPlanet.Views
{
    internal class PlanetDetailsView
    {
        public void ShowPlanetDetails(Planet planet)
        {
            AnsiConsole.MarkupLine($"[yellow bold] {planet.Name} [/]\n");
            AnsiConsole.WriteLine($"\n{planet.Description}\n");

            if (planet.IsIndependent == false) AnsiConsole.MarkupLine("[bold] Planeta [green]nalezy[/] do Dominium[/]");
            else AnsiConsole.MarkupLine("[bold]Planeta [red]NIE [/]nalezy do Dominium[/]");


            string drink = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("")
                .AddChoices("wyjdz"));
        }
    }
}
