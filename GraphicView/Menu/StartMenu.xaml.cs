using DominiumPlanet.Contollers;
using DominiumPlanet.Models;
using DominiumPlanet.Services;
using System.Windows;
using System.Windows.Controls;

namespace GraphicView.Menu
{
    public partial class StartMenu : UserControl
    {
        private UtilsController utilsController = new UtilsController();
        private GameState gameState = new GameState();
        private FileGameServices fileGameServices = new FileGameServices();
        private List<Planet> planetList = PlanetCreator.CreatePlanetList();
        private List<Decision> decisionList = DecisionCreator.CreateDecisionList();
        private List<(int, Decision)> raportList = new List<(int, Decision)>();

        public StartMenu()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;


            mainWindow.ShowPlot();
            mainWindow.SetGameData(gameState, planetList, decisionList, raportList);
            //mainWindow.ShowMainMenu();
        }
        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var loadedData = utilsController.LoadGame(gameState, fileGameServices, planetList, decisionList, raportList);
                var mainWindow = (MainWindow)Application.Current.MainWindow;

                mainWindow.SetGameData(loadedData.Item1, loadedData.Item2, loadedData.Item3, loadedData.Item4);
                mainWindow.ShowMainMenu();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }
        private void EndGame_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
