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
        private readonly PlayerDetailsView playerDetailsView = new();
        private readonly DecisionDetailsView decisionDetailsView= new();
        private List<Planet> planetList = PlanetCreator.CreatePlanetList();
        private List<Decision> decisionList = DecisionCreator.CreateDecisionList();
        GameServices gameServices = new GameServices();
        GameState gameState = new GameState();
        

        public void RunProgram()
        {
            bool running = true;

            while (running)
            {
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
                            ShowPlayerStatistics();
                            break;
                        }
                    case 3:
                        {
                            ShowDecisions();
                            //EndTurn();
                            break;
                        }
                    case 4:
                        {
                            EndTurn();
                            //Console.ReadKey(true);
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

        private void ShowPlayerStatistics()
        {
            playerDetailsView.ShowPlayerDetails(gameState);
        }

        private void ShowDecisions()
        {
            //Console.WriteLine("show decision text");
            int choice = decisionMenu.ShowMenu();
            //jakos to trzba przypisac
            //Decision selectedDecision = decisionList.;
            //decisionDetailsView.ShowDecisionDetails();
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
