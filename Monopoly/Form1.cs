using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Monopoly.Forms;
using Monopoly.Utility;
using Monopoly.Models;
using Monopoly.Visuals;
using Monopoly.Visuals.Collections;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        private Board board;
        private PlayerVisualGroup playerVisualGroup;
        private TurnKeeper turnKeeper;

        public Form1()
        {
            InitializeComponent();

            board = Board.LoadBoard();
            board.DrawBoard(this);
            this.playerVisualGroup = board.PlayerVisualGroup;

            DiceForm diceForm = new DiceForm();
            diceForm.Show();

            this.playerVisualGroup.Setup(this);

            turnKeeper = new TurnKeeper(board);

        }

        public void RequestRedraw()
        {
            playerVisualGroup.Update();
        }
    }
}
