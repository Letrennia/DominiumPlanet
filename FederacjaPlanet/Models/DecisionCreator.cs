using System;
using System.Collections.Generic;
using System.Text;

using FederacjaPlanet.Models;
namespace FederacjaPlanet.Models
{
    public class DecisionCreator
    {
        public static List<Decision> CreateDecisionList()
        {
            Decision decision1 = new Decision
            {
                Name = "decision1",
                Description = "desc1",
                Cost = 100,
                CostType = "Treasury",
                Gain = 0,
                GainType = "",
                IsActive = true,
                option1 = "Podnies podatki od eksportu zywnosci",
                option2 = "Zostaw Wenus w spokoju"
               
            };
            Decision decision2 = new Decision
            {
                Name = "decision2",
                Description = "desc2",
                Cost = 500,
                CostType = "Treasury",
                Gain = 10,
                GainType = "Food",
                IsActive = false,
                option1 = "Sfinansuj ekspedyzje na Mars",
                option2 = "Poczekaj z finansowaniem"
            };
            Decision decision3 = new Decision
            {
                Name = "decision3",
                Description = "desc3",
                Cost = 100,
                CostType = "Budget",
                Gain = 25,
                GainType = "Energy",
                IsActive = true,
                option1 = "Zadluz sie",
                option2 = "Nie bierz kolejnego kredytu"
            };





        List<Decision> decisionList = new List<Decision>
            {
                decision1, decision2, decision3
            };
            
            return decisionList;
        }
    }
}
