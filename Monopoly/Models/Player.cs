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
        public Action OnBalanceChanged;

        private Board board;

        public int Number;
        public int[] Position = new int[2] { 0,0 };


        public Player(int number, Board board)
        {
            this.Number = number;
            this.board = board;
        }

        public void Move(int spacesToMove)
        {
            int side = (Position[0] + ((Position[1] + spacesToMove) / 10)) % 4;
            int position = (Position[1] + spacesToMove) % 10;
            Position = new int[2]{ side, position };
        }

        public Point GetPositionInFormSpace()
        {
            int[] location = board.GetTileLocation(this.Position[0], this.Position[1]);
            return new Point(location[0], location[1]);
        }

        public int GetBalance()
        {
            return balance;
        }

        public void SetBalance(int amount)
        {
            this.balance -= amount;
            OnBalanceChanged?.Invoke();
        }

        public bool CanAfford(Property property)
        {
            return (balance > property.Price);
        }

        public void GoToJail(Board board)
        {
            Point newPos = board.GetProperty("Jail").WorldPosition;
            Position = new int[2]{newPos.X, newPos.Y};
        }
    }
}
