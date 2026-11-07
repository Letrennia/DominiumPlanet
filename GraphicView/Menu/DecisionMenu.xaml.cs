using DominiumPlanet.Models;
using System.Windows;
using System.Windows.Controls;

namespace GraphicView.Menu
{
    public partial class DecisionMenu : UserControl
    {
        public DecisionMenu(List<Decision> decisionList)
        {
            InitializeComponent();

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

        private void LeaveMenu_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowMainMenu();
        }
    }
}
