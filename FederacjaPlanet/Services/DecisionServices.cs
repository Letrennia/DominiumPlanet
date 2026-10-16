using FederacjaPlanet.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Services
{
    internal class DecisionServices
    {
        public List<Decision> WhichDecision(Decision decision, GameState gameState, List<Planet> planetList, List<Decision> decisionList)
        {
            if (gameState.Treasury - decision.Cost < 0)
            {
                AnsiConsole.MarkupLine("[red]Nie możesz sfinansować tego przedsięwzięcia.[/]"); //to trzeba przeniesc do view
                return decisionList;
            }

            AnsiConsole.MarkupLine("[green]Zrealizowano przedsięwzięcie.[/]"); //to trzeba przeniesc do view

            decision.IsActive = false;
            decisionList.Remove(decision);

            if (decision.Name == "Kredyt" || decision.Name == "Spłać część kredytu")
                BankDecision(decision, gameState, planetList);
            else if (decision.Name == "Wygłoś mowę")
                SpeechDecision(decision, planetList);
            else
                BasicDecisionConsequences(decision, gameState, planetList);

            return decisionList;

        }
        private void BasicDecisionConsequences(Decision decision, GameState gameState, List<Planet> planetList)
        {


            decision.IsActive = false;
            gameState.Treasury -= decision.Cost;
            gameState.Treasury += decision.GainBudgetFrom.Item1;

            Planet? planetFrom = planetList.Find(x => x.Name == decision.PlanetName);
            planetFrom?.Authority += decision.GainAuthority;
            planetFrom?.PublicSatisfaction += decision.GainPublicSatisfaction;

            if (decision.GainBudgetFrom.Item3 != "")
            {
                Planet? planetTo = planetList.Find(x => x.Name == decision.GainBudgetFrom.Item3);

                planetFrom?.Budget -= decision.GainBudgetFrom.Item1;
                planetTo?.Budget += decision.GainBudgetFrom.Item1; //trzeba dodac moze zabezpieczenie
            }

            if (decision.FoodDistribution.Item3 != "")
            {
                Planet? planetTo = planetList.Find(x => x.Name == decision.FoodDistribution.Item3);

                planetFrom?.Food -= decision.FoodDistribution.Item1;
                planetTo?.Food += decision.FoodDistribution.Item1; //trzeba dodac moze zabezpieczenie
            }

            if (decision.EnergyDistribution.Item3 != "")
            {
                Planet? planetTo = planetList.Find(x => x.Name == decision.EnergyDistribution.Item3);

                planetFrom?.Energy -= decision.EnergyDistribution.Item1;
                planetTo?.Energy += decision.EnergyDistribution.Item1; //trzeba dodac moze zabezpieczenie
            }


        }

        private void BankDecision(Decision decision, GameState gameState, List<Planet> planetList)
        {
            Planet? planet = planetList.Find(x => x.Name == "Ziemia");

            //splacanie kredytu
            gameState.Treasury -= decision.Cost;
            gameState.Dept -= decision.Cost;
            planet?.Authority += decision.GainAuthority;

            //branie kredytu
            gameState.Treasury += decision.GainBudgetFrom.Item1;
            gameState.Dept += Convert.ToInt32(decision.GainBudgetFrom.Item1 * 1.2);

            if (decision.Name == "Kredyt")
            {
                gameState.DeptCount++;
            }

        }

        private void SpeechDecision(Decision decision, List<Planet> planetList)
        {
            foreach (Planet planet in planetList)
            {
                planet.Authority += decision.GainAuthority;
            }

            decision.IsActive = false;
        }
    }
}
