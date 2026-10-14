using System;
using System.Collections.Generic;
using System.Text;

namespace FederacjaPlanet.Models
{
    public class Decision
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Cost { get; set; }
        public string CostType { get; set; } = "";
        public int Gain { get; set; }
        public string GainType { get; set; } = "";
        public bool IsActive { get; set; }
        public string option1 { get; set; } = "";
        public string option2 { get; set; } = "";

        //idk czy dawac tutaj opcje wyboru czy tak/nie na boola


    }
}
