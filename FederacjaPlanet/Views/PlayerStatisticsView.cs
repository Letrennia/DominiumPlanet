using DominiumPlanet.Models;
using Spectre.Console;
namespace DominiumPlanet.Views
{
    public class PlayerStatisticsView
    {
        public void ShowPlayerDetails(GameState gameState)
        {
            AnsiConsole.Write(new Rule($"[yellow]Tura: {gameState.Turn}[/] [grey]|[/] " +
                $"[yellow]Skarb państwa: {gameState.Treasury}[/] [grey]|[/] " +
                $"[yellow]Zadłużenie: {gameState.Debt}[/]").RuleStyle("grey"));
            AnsiConsole.Write("\n");
        }
    }
}
