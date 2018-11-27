using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Monopoly.Forms;
using Monopoly.Utility;
using Monopoly.Models;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        private Board board;
        public Form1()
        {
            InitializeComponent();

            board = Board.LoadBoard();
            board.Draw(this);

            DiceForm diceForm = new DiceForm();
            diceForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            board.DrawPlayers(this);
        }
    }
}
