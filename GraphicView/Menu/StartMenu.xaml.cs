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

using DominiumPlanet.Contollers;

namespace GraphicView.Menu
{
    public partial class StartMenu : UserControl
    {
        GameController? gameController;
        public StartMenu()
        {
            InitializeComponent();
        }


        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;

            mainWindow.ShowMainMenu();
        }
        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {
            gameController?.LoadGame();
        }
        private void EndGame_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
