using System;
using System.Collections.Generic;
using System.Text;
using FederacjaPlanet.Models;
namespace FederacjaPlanet.Services
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


        public void NextTurn(GameState gameState)
        {
            gameState.Turn++;
        }
    }
}
