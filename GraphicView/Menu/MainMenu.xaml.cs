using DominiumPlanet.Contollers;
using DominiumPlanet.Models;
using DominiumPlanet.Services;
using GraphicView.Statistics;
using System.Windows;
using System.Windows.Controls;


namespace GraphicView.Menu
{

    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ShowRaport_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowRaport();
        }

        private void ShowPlanetsMenu_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;

            mainWindow.ShowPlanetMenu();
        }

        private void ShowStatistics_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowPlanetStatistics();
        }

        private void ShowDecisionMenu_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowDecisionMenu();
        }

        private void EndTurn_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.EndTurn();
        }

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.SaveGame();
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
