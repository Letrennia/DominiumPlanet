using FederacjaPlanet.Models;
using Spectre.Console;

namespace FederacjaPlanet.Views
{
    public class FederationStatisticsView
    {
        public void ShowFederationStatistics(List<Planet> planetList)
        {
            
            var table1 = createTable("Federacja Planet - Układ Centralny", planetList, false);
            var table2 = createTable("Planety spoza Federacji", planetList, true);

            AnsiConsole.Write(table1);
            AnsiConsole.Write(table2);

            AnsiConsole.Write("SK - Sojusz Księżycowy\n");

            string exit = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("")
                .AddChoices("wyjdz"));
        }


        private Table createTable(string title, List<Planet> planetList, bool independentOption)
        {
            var table = new Table();
            table.Title(title);
            table.AddColumn("Planeta");
            table.AddColumn("Budzet");
            table.AddColumn("Zywnosc");
            table.AddColumn("Energia");
            table.AddColumn("Zadowolenie spoleczne");
            table.AddColumn("Autorytet wladzy");
            table.AddColumn("Produkcja zywnosci (co ture)");
            table.AddColumn("Produkcja energii (co ture)");
            table.AddColumn("Zuzycie zywnosci (co ture)");
            table.AddColumn("Zuzycie energii (co ture)");

            foreach (Planet planet in planetList)
            {
                if (planet.IsIndependent == independentOption) addRowToTable(table, planet);
            } 

            return table;
        }

        private void addRowToTable(Table table, Planet planet)
        {
            table.AddRow(
                planet.Name,
                planet.Budget.ToString(),
                planet.Food.ToString(),
                planet.Energy.ToString(),
                planet.PublicSatisfaction.ToString(),
                planet.Authority.ToString(),
                planet.FoodProduction.ToString(),
                planet.EnergyProduction.ToString(),
                planet.FoodUsage.ToString(),
                planet.EnergyUsage.ToString()
                );
        }
    }
}
