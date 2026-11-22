using DominiumPlanet.Models;
//using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

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
            //MessageBox.Show(planet.Name);
            DataContext = new
            {
                BackgroundImage = new BitmapImage(
                    new Uri($"pack://application:,,,/Images/{planet.Name}.jpg",
                            UriKind.Absolute))
            };

            if (planet.IsIndependent == false)
            {
                PlanetIndependence.Text = "Planeta należy do Dominium.";
                PlanetIndependence.Foreground = Brushes.LightGreen;
            }
                
            else
            {
                PlanetIndependence.Text = "Planeta NIE należy do Dominium.";
                PlanetIndependence.Foreground = Brushes.PaleVioletRed;
            } 
        }
        private void LeavePlanet_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowPlanetMenu();
        }
    }
}
