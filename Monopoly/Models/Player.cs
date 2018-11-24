using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Models
{
    public class Player
    {
        private int balance = 1500;
        public Action<int> OnBalanceChanged;

        public int PlayerNumber;
        public PlayerView PlayerForm;
        public Image PlayerImage;
        public int[] Position = new int[2] { 0,0 };

        public void Move(int spacesToMove)
        {
            Position[1] += spacesToMove + 1;
            Position[0] += (Position[1] /= 10);
            Form1.instance.MovePlayer(this, Position);
        }
    }
}
