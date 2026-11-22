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

        public (GameState, List<Planet>, List<Decision>, List<(int, Decision)>) LoadGame(GameState gameState, FileGameServices fileGameServices,  
            List<Planet> planetList, List<Decision> decisionList, List<(int, Decision)> raportList)
        {
            SaveDataModel saveDataModel = fileGameServices.ReadGameFromJSON();

            if (saveDataModel?.GameState == null) return (null, null, null, null);

            gameState = saveDataModel.GameState;
            planetList = gameState.Planets;
            decisionList = gameState.Decisions;
            raportList = saveDataModel.Raport ?? new List<(int, Decision)>();

            if (raportList?.Count() == 0) return (null, null, null, null);

            foreach (var raport in raportList)
            {
                string decName = raport.Item2.Name;
                Decision? dec = decisionList.Find(x => x.Name == decName);
                if (dec != null && dec.IsActive != raport.Item2.IsActive)
                {
                    dec.IsActive = raport.Item2.IsActive;
                }
            }

            return (gameState, planetList, decisionList, raportList);

        }
    }
}
