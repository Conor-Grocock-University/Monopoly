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

        public int PlayerNumber;
        public PlayerView PlayerForm;
        public Image PlayerImage;
        public Point Position = new Point(0,0);

        public void Move(int spacesToMove)
        {
            int y = Position.Y + spacesToMove + 1;
            int x = Position.X + (y /= 10);
            Console.WriteLine(x + ", " + y);
            Position.Offset(x, y);
            Console.WriteLine(Position);
        }
    }
}
