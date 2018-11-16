using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Monopoly.Forms;
using Monopoly.Utility;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Player.Player[] players = new Player.Player[8];
        public Dictionary<Player.Player, PictureBox> playerPiece;

        public Board board;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            board = Board.LoadBoard();
            board.Draw(this);
            playerPiece = new Dictionary<Player.Player, PictureBox>();

            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player.Player
                {
                    PlayerNumber = i,
                    PlayerImage = File.getImageFromName("Players/" + i + ".png"),
                    PlayerForm = new PlayerView()
                };

                players[i].PlayerForm.Show();
                players[i].PlayerForm.setPlayer(players[i]);
                players[i].OnBalanceChanged += players[i].PlayerForm.OnPlayerBalanceChanged;
                players[i].OnBalanceChanged(1500);

                PictureBox playerPictureBox = new PictureBox {Image = players[i].PlayerImage};
                Point startPoint = board.StartPoint;
                startPoint.X += new Random().Next(0,90);
                startPoint.Y += new Random().Next(0, 90);
                playerPictureBox.Location = startPoint;
                this.Controls.Add(playerPictureBox);
                playerPictureBox.BringToFront();
                playerPiece[players[i]] = playerPictureBox;
            }

            DiceForm diceForm = new DiceForm();
            diceForm.Show();

            GlobalStorage.OnNextPlayerTurn(players[GlobalStorage.playerTurn]);
            GlobalStorage.OnPlayerTurnCompleted += OnPlayerTurnCompleted;

        }

        private void OnPlayerTurnCompleted()
        {
            GlobalStorage.playerTurn++;
            GlobalStorage.OnNextPlayerTurn(players[GlobalStorage.playerTurn]);
        }

        public void MovePlayerPiece(Player.Player p)
        {
            var newPosition = board.GetProperty(p.Position);
            playerPiece[p].Location = newPosition.WorldPosition;
            Console.WriteLine($@"{p.Position.X}, {p.Position.Y}");
            playerPiece[p].BringToFront();
        }
    }
}
