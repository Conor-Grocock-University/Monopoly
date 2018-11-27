using Monopoly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly.Visuals
{
    public class PlayerVisual
    {
        public Player Player;
        public PictureBox pictureBox;
        public PlayerView playerView;

        public PlayerVisual(ref Player player, ref PictureBox pictureBox)
        {
            this.Player = player;
            this.pictureBox = pictureBox;
        }       
    }
}
