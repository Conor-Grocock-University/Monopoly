using Monopoly.Forms;
using System;
using System.Collections.Generic;
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
        public void StartTurn()
        {
            board.playerVisualGroup.Get(CurrentTurnPlayer).playerView.BringToFront();
            DiceForm.Instance.BringToFront();
            DiceForm.Instance.PostDiceRoll = PostRoll;
            DiceForm.Instance.AllowRoll();
        }
        
        //After roll
        //Bring current player to front
        //Move Player
        //Allow purchase
        //Enable ending turn

        public void PostRoll()
        {
            board.playerVisualGroup.Get(CurrentTurnPlayer).playerView.BringToFront();
            board.playerVisualGroup.Get(CurrentTurnPlayer).Player.Move(DiceForm.Instance.dTotal);
            board.Draw();
            board.playerVisualGroup.Get(CurrentTurnPlayer).playerView.PlayerEndTurn = EndTurn;
            board.playerVisualGroup.Get(CurrentTurnPlayer).playerView.AllowEndTurn();
        }

        //End turn
        //increment turn player
        //Start again
        public void EndTurn()
        {
            CurrentTurnPlayer++;
            if (CurrentTurnPlayer > 3) CurrentTurnPlayer = 0;
            StartTurn();
        }
    }
}
