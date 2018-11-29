using Monopoly.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Forms;
using Monopoly.Models;

namespace Monopoly.Visuals.Collections
{
    public class PlayerVisualGroup
    {
        private PlayerVisual[] playerVisuals = new PlayerVisual[4];
        public void Set(int i, PlayerVisual playerVisual)
        {
            playerVisuals[i] = playerVisual;
            playerVisuals[i].playerView = new PlayerView(playerVisuals[i]);
            playerVisuals[i].playerView.Show();
        }

        public PlayerVisual Get(int playerIndex)
        {
            return playerVisuals[playerIndex];
        }

        public void Setup(Form1 form)
        {
            for (int i = 0; i < playerVisuals.Length; i++)
            {
                form.Controls.Add(playerVisuals[i].pictureBox);
                playerVisuals[i].pictureBox.BringToFront();
            }
        }

        public void Update()
        {
            for (int i = 0; i < playerVisuals.Length; i++)
            {
                Point p = playerVisuals[i].Player.GetPositionInFormSpace();
                p.Offset(Board.PropertySize / 4, Board.PropertySize / 4);
                playerVisuals[i].pictureBox.Location = p;
                playerVisuals[i].pictureBox.BringToFront();
            }
        }
    }
}
