using DominiumPlanet.Models;
using System.Windows;
using System.Windows.Controls;
using DominiumPlanet.Services;

namespace GraphicView.ItemInformation
{

    public partial class DecisionDetails : UserControl
    {
        private Decision decision;
        private GameState gameState;
        private DecisionServices decisionServices = new DecisionServices();
        private List<(int, Decision)> raportList;
        private List<Planet> planetList;
        public DecisionDetails(Decision _decision, GameState _gameState, List<Planet> _planetList, List<(int, Decision)> _raportList)
        {
            InitializeComponent();
            this.decision = _decision;
            this.gameState = _gameState;
            this.planetList = _planetList;
            this.raportList = _raportList;

            ShowDecisionInfo();
        }

        private void ShowDecisionInfo()
        {
            DecisionName.Text = decision.Name;
            DecisionDescription.Text = decision.Description;
            DecisionCost.Text = $"Koszt: {decision.Cost.ToString()}";
            DecisionOption1.Content = decision.option1;
            DecisionOption2.Content = decision.option2;


        }


        private void Option1_Click(object sender, RoutedEventArgs e)
        {
            if (gameState.Treasury - decision.Cost < 0) 
            { 
                MessageBox.Show("Nie możesz sfinansować tego przedsięwzięcia."); 
            }
            else
            {
                MessageBox.Show("Zrealizowano przedsięwzięcie");
                decisionServices.WhichDecision(decision, gameState, planetList, raportList);
            }

            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowMainMenu();
        }
        private void Option2_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowDecisionMenu();
        }
    }
}
