using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Monopoly.Utility;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        private Player.Player[] players = new Player.Player[8];
        private Dictionary<Player.Player, PictureBox> playerPeice;

        public Board board;
        public Form1()
        {
            InitializeComponent();
            board = Board.LoadBoard();
            board.Draw(this);
            playerPeice = new Dictionary<Player.Player, PictureBox>();

            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player.Player();
                players[i].playerNumber = i;
                players[i].PlayerImage = File.getImageFromName("Players/" + i + ".png");
                players[i].playerForm = new PlayerView();
                players[i].playerForm.Show();
                players[i].playerForm.setPlayer(players[i]);
                players[i].OnBalanceChanged += players[i].playerForm.OnPlayerBalanceChanged;
                players[i].OnBalanceChanged(1500);

                PictureBox playerPictureBox = new PictureBox();
                playerPictureBox.Image = players[i].PlayerImage;
                Point startPoint = board.StartPoint;
                startPoint.X += new Random().Next(0,90);
                startPoint.Y += new Random().Next(0, 90);
                playerPictureBox.Location = startPoint;
                this.Controls.Add(playerPictureBox);
                playerPictureBox.BringToFront();
            }
        }
    }
}
