using System;
using System.Collections.Generic;
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


        public void NextTurn(GameState gameState, List<Decision> decisionList)
        {
            gameState.Turn++;
            checkGameConditions(gameState);
            DecisionServices.UpdateDecisionList(gameState.Turn, decisionList);
            AnimationView.AnimationTurn(gameState.Turn);
        }


        private void checkGameConditions(GameState gameState)
        {
            // jesli autorytet spadnie ponizej 20 to np bunt
            // jezeli bankierzy maja 4 to obalaja gracza
            // skarbiec NIE MOZE byc pusty
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
        }
    }
}
