using DominiumPlanet.Models;
using DominiumPlanet.Services;
using DominiumPlanet.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominiumPlanet.Contollers
{
    public class UtilsController
    {
        private void ShowReport()
        {
            //raportView.ShowRaportDetails(raportList);
        }

        private void ShowPlanets()
        {
            //int choice = planetMenu.ShowMenu(gameState);
            //if (choice == 6) return;
            //Planet selectedPlanet = planetList[choice];
            //planetDetailsView.ShowPlanetDetails(selectedPlanet);

        }

        private void ShowFederationStatistics()
        {
            //federationStatisticsView.ShowFederationStatistics(planetList);

        }

        private void ShowDecisions(List<Decision> decisionList, GameState gameState)
        {
            //string choice = decisionMenu.ShowMenu(gameState, decisionList);
            //if (choice == "Wyjdz") return;

            //Decision chosenDecision = decisionList[decisionList.Count - 1]; //zastepcze ale nie dziala

            //foreach (Decision decision in decisionList)
            //{
            //    if (decision.Name == choice)
            //    {
            //        chosenDecision = decision;
            //        break;
            //    }
            //}
            //int chooseOption = decisionDetailsView.ShowDecisionDetails(chosenDecision, gameState);
            //if (chooseOption == 0) decisionServices.WhichDecision(chosenDecision, gameState, planetList, raportList);
        }

        public void EndTurn(GameServices gameServices, GameState gameState, List<Planet> planetList, List<Decision> decisionList)
        {
            gameServices.CallculateResources(planetList);
            gameServices.NextTurn(gameState, decisionList, planetList);
        }

        public void SaveGame(GameState gameState, FileGameServices fileGameServices, List<Planet> planetList, List<Decision> decisionList, List<(int, Decision)> raportList)
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

        public static void LoadGame(GameState gameState, FileGameServices fileGameServices,  List<Planet> planetList, List<Decision> decisionList, List<(int, Decision)> raportList)
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
    }
}
