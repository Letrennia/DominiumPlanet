using DominiumPlanet.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace GraphicView.Statistics
{
    public partial class PlanetStatisticView : UserControl
    {
        public PlanetStatisticView(List<Planet> planetList)
        {
            InitializeComponent();
            LoadPlanetData(planetList);
        }

        private void LoadPlanetData(List<Planet> planetList)
        {
            PlanetRows.Rows.Clear();

            CreateTable(planetList, false);
            CreateTable(planetList, true);
        }

        private void CreateTable(List<Planet> planetList, bool planetIndependence)
        {
            foreach (Planet planet in planetList)
            {
                if (planet.IsIndependent == planetIndependence)
                    AddRowToTable(planet, planetIndependence);
            }
        }

        private void AddRowToTable(Planet planet, bool planetIndependence)
        {
            TableRow row = new TableRow();

            row.Cells.Add(CreateCell(planet.Name));
            row.Cells.Add(CreateCell(planet.Food.ToString(), planet.Food, planetIndependence));
            row.Cells.Add(CreateCell(planet.Energy.ToString(), planet.Energy, planetIndependence));
            row.Cells.Add(CreateCell(planet.PublicSatisfaction.ToString(), planet.PublicSatisfaction, planetIndependence));
            row.Cells.Add(CreateCell(planet.Authority.ToString(), planet.Authority, planetIndependence));
            row.Cells.Add(CreateCell(planet.FoodProduction.ToString()));
            row.Cells.Add(CreateCell(planet.EnergyProduction.ToString()));
            row.Cells.Add(CreateCell(planet.FoodUsage.ToString()));
            row.Cells.Add(CreateCell(planet.EnergyUsage.ToString()));

            if (planetIndependence == true)
                IndependentPlanetRows.Rows.Add(row);
            else
                PlanetRows.Rows.Add(row);
        }

        private TableCell CreateCell (string value)
        {
            Paragraph paragraph = new Paragraph(new Run(value))
            {
                TextAlignment = TextAlignment.Center,
                BorderBrush = Brushes.PaleVioletRed,
                BorderThickness = new Thickness(1)
            };
            return new TableCell(paragraph)
            {
                TextAlignment = TextAlignment.Center
            };
        }

        private TableCell CreateCell(string stringValue, int intValue, bool planetIndependence)
        {
            TableCell cell = CreateCell(stringValue);
            //cell.BorderBrush = Brushes.PaleVioletRed;
            //cell.BorderThickness = new Thickness(1);
            if (!planetIndependence && intValue < 20)
            {
                cell.Background = Brushes.Red;
            }
            return cell;
        }


        private void LeaveStatistics_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowMainMenu();
        }
    }

}
