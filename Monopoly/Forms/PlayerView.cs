using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monopoly.Utility;

namespace Monopoly
{
    public partial class PlayerView : Form
    {
        public PlayerView()
        {
            InitializeComponent();
            GlobalStorage.OnNextPlayerTurn += player1 =>
            {
                if (player1 == player) enablePanel();
            };
        }

        private Player.Player player;
        public void setPlayer(Player.Player player)
        {
            this.player = player;
            lblPlayerName.Text = "Player " + player.PlayerNumber;
            Console.WriteLine(player.PlayerImage.ToString());
            oPlayerIcon.Image = player.PlayerImage;
        }

        private void enablePanel()
        {
            GlobalStorage.OnDiceRollComplete += OnDiceRollComplete;
        }

        private void OnDiceRollComplete()
        {
            player.Move(GlobalStorage.dice[0] + GlobalStorage.dice[1]);
            Form1.instance.MovePlayerPiece(player);
        }

        private void disablePanel(object sender, EventArgs e)
        {
            btnEndTurn.Enabled = false;
            GlobalStorage.OnDiceRollComplete -= OnDiceRollComplete;
            GlobalStorage.OnPlayerTurnCompleted();
        }
    }
}
