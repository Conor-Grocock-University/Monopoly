using Monopoly.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                playerVisuals[i].pictureBox.Location = p;
                playerVisuals[i].pictureBox.BringToFront();
                Debug.Print(Severity.Error, "Player visual updated");
                Debug.Print(Severity.Error, p.ToString());
            }
        }
    }
}
