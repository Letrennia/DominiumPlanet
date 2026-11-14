using DominiumPlanet.Contollers;
using DominiumPlanet.Models;
using DominiumPlanet.Services;
using GraphicView.Menu;
using GraphicView.ItemInformation;
using GraphicView.PlanetInformation;
using GraphicView.Statistics;
using System.Windows;
using GraphicView.Plot;
namespace GraphicView
{

    public partial class MainWindow : Window
    {
        private PlayerStatisticView? playerStatisticView;
        private GameState gameState = new GameState();
        private UtilsController utilsController = new UtilsController();
        private GameServices gameServices = new GameServices();

        private List<(int, Decision)>? raportList = new List<(int, Decision)>();
        private List<Planet>? planetList = new List<Planet>();
        private List<Decision>? decisionList = new List<Decision>();

        public MainWindow()
        {
            InitializeComponent();
            ShowStartMenu();

            GameServices.ShowRiotMessage = (planetName, money) =>
            {
                MessageBox.Show($"Na {planetName} wybuchły zamieszki. Od tej pory dochód Skarbca będzie mniejszy o {money}. " +
                    $"Jeśli nie zapanujesz nad sytuacją autorytet władzy centralnej będzie stopniowo malał.");
            };
            GameServices.ShowRiotEndMessage = (planetName, money) =>
            {
                MessageBox.Show($"Zamieszki na {planetName} chwilowo ustały. Dochód Skarbca zwiększy się o {money}.");
            };
            GameServices.GameOverIndependece = (planetName) =>
            {
                MessageBox.Show($"{planetName} odłączyło się od Sol Dominium. Twoja pozycja nie jest już respektowana.");
            };
            GameServices.GameOverEmptyTreasure = () =>
            {
                MessageBox.Show("GAME OVER. Skarbiec nie może pozostać pusty");
            };
            GameServices.GameOverDebt = () =>
            {
                MessageBox.Show("GAME OVER. Bankierzy wyczuli w tobie słabość. Zostałeś obalony.");
            };
            FileGameServices.PositiveRead = () =>
            {
                MessageBox.Show("Poprawnie zapisano grę.");
            };
        }




        public void SetGameData(GameState _gameState, List<Planet> _planetList, List<Decision> _decisionList, List<(int, Decision)> _raportList)
        {
            this.gameState = _gameState;
            this.planetList = _planetList;
            this.decisionList = _decisionList;
            this.raportList = _raportList ?? new List<(int, Decision)>();
        }




        public void ShowDecisionDetails(Decision decision, GameState gameState)
        {
            CurrentView.Content = new DecisionDetails(decision, gameState, planetList, raportList);
        }



        public void ShowPlayerStatistics()
        {
            PlayerStat.Content = playerStatisticView;
        }
        public void ShowStartMenu()
        {
            CurrentView.Content = new StartMenu();
        }
        public void ShowMainMenu()
        {
            playerStatisticView = new PlayerStatisticView(gameState);
            CurrentView.Content = new MainMenu();
            ShowPlayerStatistics();
        }
        public void ShowPlot()
        {
            //PlotDominium plotDominium = new PlotDominium();
            CurrentView.Content = new PlotDominium();
        }

        public void ShowPlanetMenu()
        {
            CurrentView.Content = new PlanetMenu(planetList);
        }
        public void ShowDecisionMenu()
        {
            CurrentView.Content = new DecisionMenu(decisionList, gameState, raportList);

            playerStatisticView.PlayerStatistics(gameState);
        }
        public void ShowPlanetStatistics()
        {
            CurrentView.Content = new PlanetStatisticView(planetList);
        }
        public void ShowPlanetDetails(Planet planet)
        {
            CurrentView.Content = new PlanetDetails(planet);
        }
        public void ShowRaport()
        {
            CurrentView.Content = new RaportView(raportList);
        }


        public void EndTurn()
        {
            utilsController.EndTurn(gameServices, gameState, planetList, decisionList);

            playerStatisticView.PlayerStatistics(gameState);
        }
        public void SaveGame()
        {
            FileGameServices fileGameServices = new FileGameServices();
            utilsController.SaveGame(gameState, fileGameServices, planetList, decisionList, raportList);

            //playerStatisticView.PlayerStatistics(gameState);
        }
    }
}