using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Models
{
    public class GameState
    {
        public int Turn { get; set; } = 1;
        public int Treasury { get; set; } = 300;
        public int Debt { get; set; } = 1000;
        public int DebtCount { get; set; } = 1;
        public List<Planet> Planets { get; set; }

        public GameState() 
        {
            Planets = PlanetCreator.CreatePlanetList();
        }
    }
}
