using DominiumPlanet.Models;
using Spectre.Console;

namespace DominiumPlanet.Views
{
    public class DominiumStatisticsView
    {
        public void ShowFederationStatistics(List<Planet> planetList)
        {
            
            var table1 = createTable("Sol Dominium - Układ Centralny", planetList, false);
            var table2 = createTable("Planety spoza Dominium", planetList, true);

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
            string food = planet.Food.ToString();
            string energy = planet.Energy.ToString();
            string satisfaction = planet.PublicSatisfaction.ToString();
            string authority = planet.Authority.ToString();
            if (planet.IsIndependent == false)
            {
                if (planet.Food < 20) food = $"[red]{planet.Food.ToString()} [/]";
                if (planet.Energy < 20) energy = $"[red]{planet.Energy.ToString()} [/]";
                if (planet.PublicSatisfaction < 20) satisfaction = $"[red]{planet.PublicSatisfaction.ToString()} [/]";
                if (planet.Authority< 20) authority = $"[red]{planet.Authority.ToString()} [/]";
            }
            
            table.AddRow(
                planet.Name,
                food,
                energy,
                satisfaction,
                authority,
                planet.FoodProduction.ToString(),
                planet.EnergyProduction.ToString(),
                planet.FoodUsage.ToString(),
                planet.EnergyUsage.ToString()
                );
        }
    }
}
