using DominiumPlanet.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
                //MessageBox.Show(planet.Name);
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
