using DominiumPlanet.Models;
using DominiumPlanet.Views;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DominiumPlanet.Services
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
            else if (chosenDecision.Name == "Przekaż żywność z Wenus na Jowisz") FoodToJupiter(chosenDecision, gameState, planetList);
            else if (chosenDecision.Name == "Wygłoś mowę" || chosenDecision.Name == "Amnestia dla zdrajców") SpeechOrAmnestyDecision(chosenDecision, planetList);
            else BasicDecisionConsequences(chosenDecision, gameState, planetList);
        }


        private void BasicDecisionConsequences(Decision decision, GameState gameState, List<Planet> planetList)
        {
            decision.IsActive = false;
            gameState.Treasury -= decision.Cost;
            gameState.Treasury += decision.GainBudgetFrom;

            Planet? planetFrom = planetList.Find(x => x.Name == decision.PlanetName);
            planetFrom?.Authority += decision.GainAuthority;
            planetFrom?.PublicSatisfaction += decision.GainPublicSatisfaction;
            
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
            gameState.Treasury += decision.GainBudgetFrom;
            gameState.Debt += Convert.ToInt32(decision.GainBudgetFrom * 1.2);
            planet?.Authority += decision.GainAuthority;
            gameState.DebtCount++;
        }
        private void FoodToJupiter(Decision decision, GameState gameState, List<Planet> planetList)
        {
            Planet? planetTo = planetList.Find(x => x.Name == "Jowisz");
            Planet? planetFrom = planetList.Find(x => x.Name == "Wenus");
            planetTo?.Authority += decision.GainAuthority;
            planetTo?.PublicSatisfaction += decision.GainPublicSatisfaction;
            planetFrom?.Food -= decision.FoodDistribution.Item1;
            planetTo?.Food += decision.FoodDistribution.Item1;
            gameState.Treasury -= decision.Cost;
        }
        private void BankDecisionPayCredit(Decision decision, GameState gameState, List<Planet> planetList)
        {
            Planet? planet = planetList.Find(x => x.Name == "Ziemia");

            //splacanie kredytu
            gameState.Treasury -= decision.Cost;
            gameState.Debt -= decision.Cost;
            planet?.Authority += decision.GainAuthority;
            gameState.DebtCount--;
            if (gameState.Debt <= 0)
            {
                gameState.Debt = 0;
                decision.IsActive = false;
            }
            else decision.IsActive = true;

        }

        private void SpeechOrAmnestyDecision(Decision decision, List<Planet> planetList)
        {
            foreach (Planet planet in planetList)
            {
                planet.Authority += decision.GainAuthority;
            }

            decision.IsActive = false;
        }

        public static void UpdateDecisionList(int turn, List<Decision> decisionList)
        {
            switch (turn)
            {
                case 2:
                    {
                        for (int i = 0; i < decisionList.Count; i++)
                        {
                            if (decisionList[i].Name == "Wygłoś mowę" || decisionList[i].Name == "Amnestia dla zdrajców") 
                                decisionList[i].IsActive = false;
                            if (decisionList[i].Name == "Reformy na Marsie - los robotników" || 
                                decisionList[i].Name == "Pertraktacje z Sojuszem Księżycowym o żywność i energię" ||
                                decisionList[i].Name == "Ekspedycja na Mars")
                                decisionList[i].IsActive = true;
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < decisionList.Count; i++)
                        {
                            if (decisionList[i].Name == "Inspekcja fabryk na Marsie")
                                decisionList[i].IsActive = true;
                        }
                        break;
                    }
            }
            if (turn == 2) //mowa dostepna tylko w pierwszej turze
            {
                
            }

        }
    }
}
