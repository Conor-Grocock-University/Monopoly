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
using Monopoly.Models;
using Monopoly.Visuals;

namespace Monopoly
{
    public partial class PlayerView : Form
    {
        public PlayerView()
        {
            InitializeComponent();
        }

        public PlayerView(PlayerVisual playerVisual)
        {
            InitializeComponent();
            lblPlayerName.Text = "Player " + playerVisual.Player.Number;
            lblPLayerMoney.Text = "£" + playerVisual.Player.GetBalance();
            oPlayerIcon.Image = playerVisual.pictureBox.Image;
        }
    }
}
