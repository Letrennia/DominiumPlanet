using DominiumPlanet.Models;
//using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
                        Text = $"Tura {whichTurn}",
                        Foreground = Brushes.PaleVioletRed,
                        FontSize = 22,
                        Margin = new Thickness(5)
                    });
                }
                StackPanel decisionPanel = new StackPanel
                {
                    Orientation = Orientation.Horizontal
                };

                decisionPanel.Children.Add(new TextBlock
                {
                    Text = $"- {raport.Item2.Name}   Koszt: {raport.Item2.Cost}",
                    Foreground = Brushes.AliceBlue,
                    FontSize = 20
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
