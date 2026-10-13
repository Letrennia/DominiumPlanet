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
        private readonly PlanetDetailsView planetDetailsView = new();
        private List<Planet> planetList = PlanetCreator.CreatePlanetList();
        private readonly PlayerDetailsView playerDetailsView = new();
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
                            EndTurn();
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
            Console.WriteLine("show decision text");
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
