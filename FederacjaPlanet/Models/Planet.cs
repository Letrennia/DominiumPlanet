using System;
using System.Collections.Generic;
using System.Text;

namespace DominiumPlanet.Models
{
    public class Planet
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Food { get; set; }
        public int Energy { get; set; }
        public int PublicSatisfaction { get; set; }
        public int Authority { get; set; }

        public int FoodProduction { get; set; }
        public int EnergyProduction { get; set; }
        public int FoodUsage { get; set; }
        public int EnergyUsage { get; set; }
        public bool IsIndependent { get; set; }
        public bool Riot {  get; set; }


    }
}
