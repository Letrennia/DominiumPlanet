using System;
using System.Collections.Generic;
using System.Text;



namespace FederacjaPlanet.Models
{
    public static class PlanetCreator
    {
        public static List<Planet> CreatePlanetList()
        {
            Planet mercury = new Planet
            {
                Name = "Merkury",
                Description = "opis",
                Budget = 0,
                Food = 0,
                Energy = 0,
                PublicSatisfaction = 0,
                Authority = 0,

                FoodProduction = 0,
                EnergyProduction = 0,
                IsIndependent = true,
            };

            Planet venus = new Planet
            {
                Name = "Wenus",
                Description = "opis",
                Budget = 300,
                Food = 200,
                Energy = 120,
                PublicSatisfaction = 85,
                Authority = 45,

                FoodProduction = 100,
                EnergyProduction = 15,
                IsIndependent = false,
            };

            Planet mars = new Planet
            {
                Name = "Mars",
                Description = "opis",
                Budget = 50,
                Food = 40,
                Energy = 200,
                PublicSatisfaction = 40,
                Authority = 56,

                FoodProduction = 10,
                EnergyProduction = 70,
                IsIndependent = false,
            };

            Planet earth = new Planet
            {
                Name = "Ziemia",
                Description = "opis",
                Budget = 100,
                Food = 90,
                Energy = 80,
                PublicSatisfaction = 60,
                Authority = 50,

                FoodProduction = 10,
                EnergyProduction = 10,
                IsIndependent = false,
            };

            Planet jupiter = new Planet
            {
                Name = "Jowisz",
                Description = "opis",
                Budget = 30,
                Food = 20,
                Energy = 30,
                PublicSatisfaction = 30,
                Authority = 35,

                FoodProduction = 5,
                EnergyProduction = 5,
                IsIndependent = false,
            };

            Planet moonAliance = new Planet
            {
                Name = "Sojusz Ksiezycowy",
                Description = "opis",
                Budget = 90,
                Food = 50,
                Energy = 50,
                PublicSatisfaction = 0,
                Authority = 0,

                FoodProduction = 15,
                EnergyProduction = 15,
                IsIndependent = true,
            };


            List<Planet> planets = new List<Planet>
            {
                mercury, venus, mars, earth, jupiter, moonAliance,
            };
            //tutaj jeszcze jest case ze moonAliance to co najwyzej do negocjacji wiec moze ich wywalic i taksamo mercury
            return planets;
        }



        
    }
}
