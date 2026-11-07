using DominiumPlanet.Contollers;
using DominiumPlanet.Models;
using DominiumPlanet.Services;
using System.Windows;
using System.Windows.Controls;

namespace GraphicView.Menu
{
    /// <summary>
    /// Logika interakcji dla klasy MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        //public readonly GameController? gameController;
        private readonly UtilsController? utilsController;
        private readonly GameServices? gameServices;
        private readonly GameState? gameState;
        private readonly FileGameServices? fileGameServices;
        private List<Decision> decisionList = DecisionCreator.CreateDecisionList();
        private List<Planet> planetList = PlanetCreator.CreatePlanetList();
        private List<(int, Decision)> raportList = new List<(int, Decision)>();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ShowRaport_Click(object sender, RoutedEventArgs e)
        {
            //work in progress ;p
        }
        private void SeePlanetsMenu_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;

            mainWindow.ShowPlanetMenu();
        }
        private void ShowStatistics_Click(object sender, RoutedEventArgs e)
        {
            //okno do stat
        }
        private void ShowDecisionMenu_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;

            mainWindow.ShowDecisionMenu();
        }
        private void EndTurn_Click(object sender, RoutedEventArgs e)
        {
            utilsController?.EndTurn(gameServices, gameState, planetList, decisionList);
        }
        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {
            utilsController?.SaveGame(gameState, fileGameServices, planetList, decisionList, raportList);
        }
        private void EndGame_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
