using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class PlayerView : Form
    {
        public PlayerView()
        {
            InitializeComponent();
        }

        private Player.Player player;
        public void setPlayer(Player.Player player)
        {
            this.player = player;
            lblPlayerName.Text = "Player " + player.playerNumber;
            oPlayerIcon.Image = player.PlayerImage;
        }
    }
}
