using System;
using System.Collections.Generic;
using System.Text;

namespace DominiumPlanet.Models
{
    public class GameState
    {
        public int Turn { get; set; } = 1;
        public int Treasury { get; set; } = 300;
        public int Debt { get; set; } = 1000;
        public int DebtCount { get; set; } = 1;
        public int Income { get; set; } = 150;
        public List<Planet> Planets { get; set; }
        public List<Decision> Decisions { get; set; }

        public GameState() 
        {
            Planets = PlanetCreator.CreatePlanetList();
            Decisions = DecisionCreator.CreateDecisionList();
        }
    }
}
