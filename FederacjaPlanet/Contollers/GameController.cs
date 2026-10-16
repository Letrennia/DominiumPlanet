using FederacjaPlanet.Views;
using System;
using System.Collections.Generic;
using System.Text;
using FederacjaPlanet.Models;
using FederacjaPlanet.Services;

namespace FederacjaPlanet.Contollers
{
    public class GameController
    {
        private readonly MainMenu mainMenu = new();
        private readonly PlanetMenu planetMenu = new();
        private readonly DecisionMenu decisionMenu = new();
        private readonly PlanetDetailsView planetDetailsView = new();
        private readonly FederationStatisticsView federationStatisticsView = new();
        private readonly DecisionDetailsView decisionDetailsView= new();
        private readonly PlayerStatisticsView playerStatistics = new();
        private List<Planet> planetList = PlanetCreator.CreatePlanetList();
        private List<Decision> decisionList = DecisionCreator.CreateDecisionList();
        GameServices gameServices = new GameServices();
        GameState gameState = new GameState();
        DecisionServices decisionServices = new DecisionServices();
        

        public void RunProgram()
        {
            bool running = true;

            while (running)
            {
                playerStatistics.ShowPlayerDetails(gameState);

                int choice = mainMenu.ShowMenu();

                switch (choice)
                {
                    case 0:
                        {
                            ShowReport();
                            break;
                        }
                    case 1:
                        {
                            ShowPlanets();
                            break;
                        }
                    case 2:
                        {
                            ShowFederationStatistics();
                            break;
                        }
                    case 3:
                        {
                            ShowDecisions();
                            break;
                        }
                    case 4:
                        {
                            EndTurn();
                            break;
                        }
                    case 5:
                        {
                            EndGame();
                            break;
                        }
                }
            }

        }

        private void ShowReport()
        {
            Console.WriteLine("show report text");
        }

        private void ShowPlanets()
        {
            int choice = planetMenu.ShowMenu();
            Planet selectedPlanet = planetList[choice];
            planetDetailsView.ShowPlanetDetails(selectedPlanet);
            
        }

        private void ShowFederationStatistics()
        {
            federationStatisticsView.ShowFederationStatistics(planetList);

        }

        private void ShowDecisions()
        {
            string choice = decisionMenu.ShowMenu();
            Decision chosenDecision = decisionList[0]; //zastepcze

            foreach (Decision decision in decisionList)
            {
                if (decision.Name == choice)
                {
                    chosenDecision = decision;
                    break;
                }
            }
            int chooseOption = decisionDetailsView.ShowDecisionDetails(chosenDecision);
            if (chooseOption == 0) decisionServices.WhichDecision(chosenDecision, gameState, planetList, decisionList);
        }

        private void EndTurn()
        {
            gameServices.CallculateResources(planetList);
            gameServices.NextTurn(gameState);
        }
        


        private void EndGame()
        {
            Environment.Exit(0);
        }


    }
}
