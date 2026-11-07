using DominiumPlanet.Models;
using System.Windows;
using System.Windows.Controls;

namespace GraphicView.PlanetInformation
{
    public partial class PlanetDetails : UserControl
    {
        public PlanetDetails(Planet planet)
        {
            InitializeComponent();
            PlanetDetailsInOnePlace(planet);
        }

        private void PlanetDetailsInOnePlace(Planet planet)
        {
            PlanetName.Text = planet.Name;
            PlanetDescription.Text = planet.Description;

            if (planet.IsIndependent == false) PlanetIndependence.Text = "[bold]Planeta [green]nalezy[/] do Dominium[/]";
            else PlanetIndependence.Text = "[bold]Planeta [red]NIE [/]nalezy do Dominium[/]";
        }
        private void LeavePlanet_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowMainMenu();
        }
    }
}
