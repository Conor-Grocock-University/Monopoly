using Monopoly.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Models
{
    class TurnKeeper
    {
        private Board board;
        public int CurrentTurnPlayer = 0;

        public TurnKeeper(Board board)
        {
            this.board = board;
            StartTurn();
        }


        //Start turn
        //Bring dice to front
        private void StartTurn()
        {
            board.PlayerVisualGroup.Get(CurrentTurnPlayer).playerView.BringToFront();
            DiceForm.Instance.BringToFront();
            DiceForm.Instance.PostDiceRoll = PostRoll;
            DiceForm.Instance.AllowRoll();
        }
        
        //After roll
        //Bring current player to front
        //Move Player
        //Allow purchase
        //Enable ending turn

        private void PostRoll()
        {
            board.PlayerVisualGroup.Get(CurrentTurnPlayer).playerView.BringToFront();
            board.PlayerVisualGroup.Get(CurrentTurnPlayer).Player.Move(DiceForm.Instance.dTotal);
            board.Draw();
            
            Point pos = new Point(board.PlayerVisualGroup.Get(CurrentTurnPlayer).Player.Position[0], board.PlayerVisualGroup.Get(CurrentTurnPlayer).Player.Position[1]);
            if (board.GetProperty(pos).CanBuy(board.PlayerVisualGroup.Get(CurrentTurnPlayer).Player))
            {
                board.PlayerVisualGroup.Get(CurrentTurnPlayer).playerView.PlayerBuyProperty = PlayerBuyProperty;
                board.PlayerVisualGroup.Get(CurrentTurnPlayer).playerView.AllowBuyProperty();
            }

            board.PlayerVisualGroup.Get(CurrentTurnPlayer).playerView.PlayerEndTurn = EndTurn;
            board.PlayerVisualGroup.Get(CurrentTurnPlayer).playerView.AllowEndTurn();
        }
        
        //End turn
        //increment turn player
        //Start again
        private void EndTurn()
        {
            CurrentTurnPlayer++;
            if (CurrentTurnPlayer > 3) CurrentTurnPlayer = 0;
            StartTurn();
        }
        
        private void PlayerBuyProperty()
        {
            Point pos = new Point(board.PlayerVisualGroup.Get(CurrentTurnPlayer).Player.Position[0], board.PlayerVisualGroup.Get(CurrentTurnPlayer).Player.Position[1]);
            Property property = board.GetProperty(pos);

            board.PlayerVisualGroup.Get(CurrentTurnPlayer).Player.SetBalance(property.Price);
            property.Purchase(board.PlayerVisualGroup.Get(CurrentTurnPlayer).Player);
            board.PlayerVisualGroup.Get(CurrentTurnPlayer).playerView.AddProperty(property);
        }
    }
}
