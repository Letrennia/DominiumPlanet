using DominiumPlanet.Models;
using GraphicView.Menu;
using GraphicView.PlanetInformation;
using System.Windows;

namespace GraphicView
{

    public partial class MainWindow : Window
    {
        private List<Planet> planetList = PlanetCreator.CreatePlanetList();
        private List<Decision> decisionList = DecisionCreator.CreateDecisionList();
        public MainWindow()
        {
            InitializeComponent();
            ShowStartMenu();
        }

        public void ShowStartMenu()
        {
            CurrentView.Content = new StartMenu();
        }
        public void ShowMainMenu()
        {
            CurrentView.Content = new MainMenu();
        }
        public void ShowPlanetMenu()
        {
            CurrentView.Content = new PlanetMenu(planetList);
        }
        public void ShowDecisionMenu()
        {
            CurrentView.Content = new DecisionMenu(decisionList);
        }

        public void ShowPlanetDetails(Planet planet)
        {
            CurrentView.Content = new PlanetDetails(planet);
        }
    }
}