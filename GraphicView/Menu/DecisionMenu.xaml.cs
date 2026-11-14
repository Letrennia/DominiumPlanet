using DominiumPlanet.Models;
using System.Windows;
using System.Windows.Controls;

namespace GraphicView.Menu
{

    public partial class DecisionMenu : UserControl
    {
        private GameState gameState;
        private List<(int, Decision)> raportList;

        public DecisionMenu(List<Decision> decisionList, GameState _gameState, List<(int, Decision)> _raportList)
        {
            InitializeComponent();

            this.gameState = _gameState;
            this.raportList = _raportList;

            List<Decision> activeDecisionList = ActiveList(decisionList);
            DecisionItems.ItemsSource = activeDecisionList;

        }

        private List<Decision> ActiveList(List<Decision> decisionList)
        {
            List<Decision> activeDecisionList = new List<Decision>();
            for (int i = 0; i < decisionList.Count(); i++)
            {
                if (decisionList[i].IsActive == true)
                {
                    activeDecisionList.Add(decisionList[i]);
                }
            }
            return activeDecisionList;
        }

        private void Decision_Click(object sender, RoutedEventArgs e)
        {

            if (sender is Button button && button.DataContext is Decision decision)
            {
                var mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.ShowDecisionDetails(decision, gameState);
            }



        }

        private void LeaveMenu_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowMainMenu();
        }
    }
}

