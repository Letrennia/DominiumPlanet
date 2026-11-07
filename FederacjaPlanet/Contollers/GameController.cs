using DominiumPlanet.Views;
using System;
using System.Collections.Generic;
using System.Text;
using DominiumPlanet.Models;
using DominiumPlanet.Services;
using Spectre.Console;

namespace DominiumPlanet.Contollers
{
    public class GameController
    {
        private readonly StartMenu startMenu = new StartMenu();
        private readonly MainMenu mainMenu = new MainMenu();
        private readonly PlanetMenu planetMenu = new PlanetMenu();
        private readonly DecisionMenu decisionMenu = new DecisionMenu();
        private readonly PlanetDetailsView planetDetailsView = new PlanetDetailsView();
        private readonly DominiumStatisticsView federationStatisticsView = new DominiumStatisticsView();
        private readonly DecisionDetailsView decisionDetailsView= new DecisionDetailsView();
        private RaportDetailsView raportView = new RaportDetailsView();
        private StartView startView = new StartView();
        private GameServices gameServices = new GameServices();
        private GameState gameState = new GameState();
        private DecisionServices decisionServices = new DecisionServices();
        private FileGameServices fileGameServices = new FileGameServices();
        private List<Planet> planetList = PlanetCreator.CreatePlanetList();
        private List<Decision> decisionList = DecisionCreator.CreateDecisionList();
        private List<(int, Decision)> raportList = new List<(int, Decision)>();
        

        public void RunProgram()
        {
            AnimationView.AnimationPlanets();
            AnsiConsole.Clear();
            WelcomeScreen();
            


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

        public void EndTurn()
        {
            gameServices.CallculateResources(planetList);
            gameServices.NextTurn(gameState, decisionList, planetList);
        }
        
        public void SaveGame()
        {
            gameState.Planets = planetList;
            gameState.Decisions = decisionList;
            var save = new SaveDataModel
            {
                GameState = gameState,
                Raport = raportList
            };

            fileGameServices.SaveGameToJSON(save);
        }
        
        public void LoadGame()
        {
            SaveDataModel saveDataModel = fileGameServices.ReadGameFromJSON();

            if (saveDataModel?.GameState == null) return;

            gameState = saveDataModel.GameState;
            planetList = gameState.Planets;
            decisionList = gameState.Decisions;
            raportList = saveDataModel.Raport ?? new List<(int, Decision)>();
            
            if (raportList?.Count() == 0) return;

            foreach (var raport in raportList)
            {
                string decName = raport.Item2.Name;
                Decision? dec = decisionList.Find(x => x.Name == decName);
                if (dec != null && dec.IsActive != raport.Item2.IsActive)
                {
                    dec.IsActive = raport.Item2.IsActive;
                }
            }

        }

        private void EndGame()
        {
            Environment.Exit(0);
        }

        private void WelcomeScreen()
        {
            int choice = startMenu.ShowMenu(gameState);
            if (choice == 0)
            {
                startView.ShowStory();
                AnimationView.AnimationTurn(1);
            }
            else if (choice == 1) 
            {
                LoadGame();
                AnimationView.AnimationTurn(gameState.Turn);
            }
            else EndGame();
        }
    }
}
