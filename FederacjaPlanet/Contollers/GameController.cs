using FederacjaPlanet.Views;
using System;
using System.Collections.Generic;
using System.Text;
using FederacjaPlanet.Models;
using FederacjaPlanet.Services;
using Spectre.Console;

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
        //private readonly PlayerStatisticsView playerStatistics = new();
        private GameServices gameServices = new GameServices();
        private GameState gameState = new GameState();
        private RaportDetailsView raportView = new RaportDetailsView();
        private DecisionServices decisionServices = new DecisionServices();
        private FileGameServices fileGameServices = new FileGameServices();
        private List<Planet> planetList = PlanetCreator.CreatePlanetList();
        private List<Decision> decisionList = DecisionCreator.CreateDecisionList();
        private List<(int, Decision)> raportList = new List<(int, Decision)>();
        //Decision decision = new Decision();


        

        public void RunProgram()
        {
            bool running = true;

            while (running)
            {

                int choice = mainMenu.ShowMenu(gameState);

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
                            SaveGame();
                            break;
                        }
                    case 6:
                        {
                            LoadGame();
                            break;
                        }
                    case 7:
                        {
                            EndGame();
                            break;
                        }
                }
            }

        }

        private void ShowReport()
        {
            raportView.ShowRaportDetails(raportList);
        }

        private void ShowPlanets()
        {
            int choice = planetMenu.ShowMenu(gameState);
            if (choice == 6) return;
            Planet selectedPlanet = planetList[choice];
            planetDetailsView.ShowPlanetDetails(selectedPlanet);
            
        }

        private void ShowFederationStatistics()
        {
            federationStatisticsView.ShowFederationStatistics(planetList);

        }

        private void ShowDecisions()
        {
            string choice = decisionMenu.ShowMenu(gameState, decisionList);
            if (choice == "Wyjdz") return;

            Decision chosenDecision = decisionList[decisionList.Count - 1]; //zastepcze ale nie dziala

            foreach (Decision decision in decisionList)
            {
                if (decision.Name == choice)
                {
                    chosenDecision = decision;
                    break;
                }
            }
            int chooseOption = decisionDetailsView.ShowDecisionDetails(chosenDecision, gameState);
            if (chooseOption == 0) decisionServices.WhichDecision(chosenDecision, gameState, planetList, raportList);
        }

        private void EndTurn()
        {
            gameServices.CallculateResources(planetList);
            gameServices.NextTurn(gameState);
        }
        
        private void SaveGame()
        {
            var save = new SaveDataModel();
            save.GameState = gameState;
            save.Raport = raportList;

            fileGameServices.SaveGameToJSON(save);
        }
        
        private void LoadGame()
        {
            SaveDataModel saveDataModel = fileGameServices.ReadGameFromJSON();

            if (saveDataModel == null) return;

            gameState = saveDataModel.GameState;
            raportList = saveDataModel.Raport;

        }

        private void EndGame()
        {
            Environment.Exit(0);
        }


    }
}
