using DominiumPlanet.Models;
using System.Windows.Controls;

namespace GraphicView.Statistics
{
    public partial class PlayerStatisticView : UserControl
    {
        GameState gameState;
        public PlayerStatisticView(GameState _gameState)
        {
            InitializeComponent();
            this.gameState = _gameState;
            PlayerStatistics(gameState);
        }

        public void PlayerStatistics(GameState gameState)
        {
            PlayerTurn.Text = $"Tura: {gameState.Turn.ToString()}";
            PlayerTreasury.Text = $"Skarb: {gameState.Treasury.ToString()}";
            PlayerDebt.Text = $"Dług: {gameState.Debt.ToString()}";
        }

    }
}
