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

                    if(planetList[i].Food < 0) planetList[i].Food = 0;
                    if(planetList[i].Energy < 0) planetList[i].Energy = 0;


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
            checkGameConditions(gameState, planetList);
            gameState.Treasury += gameState.Income;
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
                RiotCondition(planet, gameState);
                RiotEndedCondition(planet, gameState);
                if (planet.Authority < 10)
                {
                    ReactionView.GameOverIndependece(planet);
                    Environment.Exit(0);
                }
                if (planet.Food < 20)
                {
                    planet.PublicSatisfaction -= 6;
                    if (planet.PublicSatisfaction < 0) planet.PublicSatisfaction = 0;
                }

                if (planet.Energy < 20)
                {
                    planet.PublicSatisfaction -= 8;
                    if (planet.PublicSatisfaction < 0) planet.PublicSatisfaction = 0;
                }
                
            }
        }

        private static void RiotCondition(Planet planet, GameState gameState)
        {
            if (planet.PublicSatisfaction <= 15)
            {
                planet.Authority -= 5;

                if (planet.Riot == false)
                {
                    string planetName;
                    int money;
                    (planetName, money) = FindPlanetData(planet);

                    ReactionView.Riot(planetName, money);
                    gameState.Income -= money;
                    planet.Riot = true;
                }

            }
        }

        private static void RiotEndedCondition(Planet planet, GameState gameState)
        {
            //zakonczenie zamieszek
            if (planet.PublicSatisfaction > 15 && planet.Riot == true)
            {
                planet.Riot = false;
                planet.Authority += 5;
                string planetName;
                int money;
                (planetName, money) = FindPlanetData(planet);
                gameState.Income += money;
                ReactionView.RiotEnded(planetName, money);

            }
        }

        private static (string, int) FindPlanetData(Planet planet)
        {
            string planetName;
            int money;
            switch (planet.Name)
            {
                case "Mars":
                    {
                        planetName = "Marsie";
                        money = 25;
                        break;
                    }
                case "Wenus":
                    {
                        planetName = "Wenus";
                        money = 50;
                        break;
                    }
                case "Ziemia":
                    {
                        planetName = "Ziemi";
                        money = 50;
                        break;
                    }
                default:
                    {
                        planetName = "Jowiszu";
                        money = 25;
                        break;
                    }
            }
            return (planetName, money);
        }
    }
}
