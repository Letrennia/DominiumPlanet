using FederacjaPlanet.Models;
using FederacjaPlanet.Views;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FederacjaPlanet.Services
{
    internal class DecisionServices
    {
        public void WhichDecision(Decision chosenDecision, GameState gameState, List<Planet> planetList, List<(int, Decision)> raportList)
        {
            if (gameState.Treasury - chosenDecision.Cost < 0) //dodac na jedzenie czy co tam badz
            {
                ReactionView.NegativeReaction(); return;
            }
            ReactionView.PositiveReaction();

            raportList.Add((gameState.Turn, chosenDecision));

            if (chosenDecision.Name == "Kredyt") BankDecisionTakeCredit(chosenDecision, gameState, planetList);
            else if (chosenDecision.Name == "Spłać część kredytu") BankDecisionPayCredit(chosenDecision, gameState, planetList);
            else if (chosenDecision.Name == "Wygłoś mowę") SpeechDecision(chosenDecision, planetList);
            else BasicDecisionConsequences(chosenDecision, gameState, planetList);
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

        private void BankDecisionTakeCredit(Decision decision, GameState gameState, List<Planet> planetList)
        {
            Planet? planet = planetList.Find(x => x.Name == "Ziemia");
            gameState.Treasury += decision.GainBudgetFrom.Item1;
            gameState.Dept += Convert.ToInt32(decision.GainBudgetFrom.Item1 * 1.2);
            planet?.Authority += decision.GainAuthority;
            gameState.DeptCount++;
        }
        private void BankDecisionPayCredit(Decision decision, GameState gameState, List<Planet> planetList)
        {
            Planet? planet = planetList.Find(x => x.Name == "Ziemia");

            //splacanie kredytu
            gameState.Treasury -= decision.Cost;
            gameState.Dept -= decision.Cost;
            planet?.Authority += decision.GainAuthority;
            gameState.DeptCount--;
            if (gameState.Dept <= 0)
            {
                gameState.Dept = 0;
                decision.IsActive = false;
            }
            else decision.IsActive = true;

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
