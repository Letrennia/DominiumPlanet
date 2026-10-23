using FederacjaPlanet.Models;
using Spectre.Console;
namespace FederacjaPlanet.Views
{
    public class PlayerStatisticsView
    {
        public void ShowPlayerDetails(GameState gameState)
        {
            AnsiConsole.Write(new Rule($"[yellow]Tura: {gameState.Turn}[/] [grey]|[/] " +
                $"[yellow]Skarb państwa: {gameState.Treasury}[/] [grey]|[/] " +
                $"[yellow]Zadluzenie: {gameState.Debt}[/]").RuleStyle("grey"));
            AnsiConsole.Write("\n");
        }
    }
}
