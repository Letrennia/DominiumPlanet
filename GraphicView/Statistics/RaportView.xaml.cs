using DominiumPlanet.Models;
using System.Windows;
using System.Windows.Controls;

namespace GraphicView.Statistics
{
    public partial class RaportView : UserControl
    {
        List<(int, Decision)>? raportList;

        public RaportView(List<(int, Decision)> raportList)
        {
            InitializeComponent();
            RaportDetailView(raportList);
        }

        private void RaportDetailView(List<(int, Decision)> raportList)
        {
            if (raportList.Count == 0)
            {
                DecisionName.Text = "Nie podjęto żadnych decyzji!";
                return;
            }


            int whichTurn = -1;

            foreach (var raport in raportList)
            {
                if (whichTurn != raport.Item1)
                {
                    whichTurn = raport.Item1;
                    RaportItems.Items.Add(new TextBlock
                    {
                        Text = $"Tura {whichTurn}"
                    });
                }
                StackPanel decisionPanel = new StackPanel
                {
                    Orientation = Orientation.Horizontal
                };

                decisionPanel.Children.Add(new TextBlock
                {
                    Text = $"- {raport.Item2.Name}   Koszt: {raport.Item2.Cost}"
                });

                RaportItems.Items.Add(decisionPanel);
            }

        }
        private void LeaveRaport_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowMainMenu();
        }
    }
}
