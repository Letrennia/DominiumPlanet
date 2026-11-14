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

namespace GraphicView.Plot
{
    public partial class PlotDominium : UserControl
    {
        private GameModel gameModel = new GameModel();
        public PlotDominium()
        {
            InitializeComponent();
            PlotDetails();
        }

        private void PlotDetails()
        {
            GameTitle.Text = gameModel.Title;
            GamePlot.Text = gameModel.Story;
            GameRules.Text = gameModel.Rules;
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowMainMenu();
        }
    }
}
