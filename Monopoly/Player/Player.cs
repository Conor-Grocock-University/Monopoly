using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Player
{
    public class Player
    {
        private int balance = 1500;
        public Action<int> OnBalanceChanged;

        public int playerNumber;
        public PlayerView playerForm;
        public Image PlayerImage;
    }
}
