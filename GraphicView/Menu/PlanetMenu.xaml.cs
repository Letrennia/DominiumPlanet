using DominiumPlanet.Models;
using System.Windows;
using System.Windows.Controls;

namespace GraphicView.Menu
{
    public partial class PlanetMenu : UserControl
    {
        public PlanetMenu(List<Planet> planetList)
        {
            InitializeComponent();
            PlanetItems.ItemsSource = planetList;
        }

        private void PlanetClicked_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Planet planet)
            {
                var mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.ShowPlanetDetails(planet);
            }
        }

        private void LeaveMenu_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowMainMenu();
        }
    }
}
