using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Utility;

namespace Monopoly.Models
{
    public class Player
    {
        private int balance = 1500;
        public Action<int> OnBalanceChanged;

        public int Number;
        public int[] Position = new int[2] { 0,0 };

        public Player(int number)
        {
            this.Number = number;
        }

        public void Move(int spacesToMove)
        {
            var positionOnSide = spacesToMove + 1;
            Position = new int[2]{ positionOnSide, (positionOnSide) %= 10 };
        }
    }
}
