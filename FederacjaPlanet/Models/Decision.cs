using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Models
{
    public class Decision
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string PlanetName { get; set; } = "";
        public int Cost { get; set; }
        public (int, string, string) GainBudgetFrom { get; set; }
        public int GainPublicSatisfaction { get; set; }
        public int GainAuthority { get; set; }
        public (int, string, string) FoodDistribution { get; set; } //ile, od, do
        public (int, string, string) EnergyDistribution { get; set; } //ile, od, do


        public bool IsActive { get; set; }
        public string option1 { get; set; } = "";
        public string option2 { get; set; } = "";

        //idk czy dawac tutaj opcje wyboru czy tak/nie na boola


    }
}
