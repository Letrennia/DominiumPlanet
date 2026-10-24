using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DominiumPlanet.Models;
using DominiumPlanet.Views;
namespace DominiumPlanet.Services
{
    public class GameServices
    {
        public void CallculateResources(List<Planet> planetList)
        {
            for (int i = 0; i < planetList.Count; i++)
            {
                if (planetList[i].IsIndependent == false)
                {
                    planetList[i].Energy += planetList[i].EnergyProduction;
                    planetList[i].Energy -= planetList[i].EnergyUsage;

                    planetList[i].Food += planetList[i].FoodProduction;
                    planetList[i].Food -= planetList[i].FoodUsage;

                }

            }
        }


        public void NextTurn(GameState gameState, List<Decision> decisionList, List<Planet> planetList)
        {
            gameState.Turn++;
            if (gameState.Turn == 10)
            {
                ReactionView.GameWon();
                Environment.Exit(0);
            }
            gameState.Treasury += 150;
            checkGameConditions(gameState, planetList);
            DecisionServices.UpdateDecisionList(gameState.Turn, decisionList);
            AnimationView.AnimationTurn(gameState.Turn);
        }


        private void checkGameConditions(GameState gameState, List<Planet> planetList)
        {
            if (gameState.Treasury == 0)
            {
                ReactionView.GameOverEmptyTreasure();
                Environment.Exit(0);
            }

            if (gameState.DebtCount == 4)
            {
                ReactionView.GameOverDebt();
                Environment.Exit(0);
            }



            foreach (Planet planet in planetList)
            {
                if (planet.IsIndependent == true) continue;
                if (planet.Authority < 10)
                {
                    ReactionView.GameOverIndependece(planet);
                    Environment.Exit(0);
                }
                if (planet.Food < 20)
                {
                    planet.PublicSatisfaction -= 10;
                    if (planet.PublicSatisfaction < 0) planet.PublicSatisfaction = 0;
                }

                if (planet.Energy < 20) planet.PublicSatisfaction -= 10;
                {
                    planet.PublicSatisfaction -= 10;
                    if (planet.PublicSatisfaction < 0) planet.PublicSatisfaction = 0;
                }

                if (planet.PublicSatisfaction <= 15)
                {
                    planet.Authority -= 5;
                    //bunt
                }
            }
        }
    }
}
