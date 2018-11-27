using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Monopoly.Controls;
using Monopoly.Utility;
using Monopoly.Models;
using Monopoly.Visuals;
using Monopoly.Visuals.Collections;

namespace Monopoly.Models
{
    public class Board
    {
        private Property[,] board;
        private Point StartPoint;

        private Player[] Players = new Player[4];
        public PlayerVisualGroup playerVisualGroup = new PlayerVisualGroup();

        private Board(Property[,] board)
        {
            this.board = board;
            CreatePlayers();
        }

        private void CreatePlayers()
        {
            for (int i = 0; i < Players.Length; i++)
            {
                Players[i] = new Player(i, this);

                PictureBox playerPictureBox = new PictureBox();
                playerPictureBox.Image = File.GetImageFromName("Players/" + Players[i].Number + ".png");
                var position = GetTileLocation(Players[i].Position[0], Players[i].Position[1]);
                playerPictureBox.Location = new Point(position[0], position[1]);

                playerVisualGroup.Set(i, new PlayerVisual(ref Players[i], ref playerPictureBox));
            }
        }

        private Form1 BoardForm;
        public void Draw()
        {
            BoardForm.RequestRedraw();
        }

        private const int PropertySize = 90;

        public void MoveRandomPlayer()
        {
            Players[0].Move(1);
        }

        public void DrawBoard(Form1 form)
        {
            BoardForm = form;
            for (var i = 0; i < board.GetLength(0); i++)
            {
                for (var j = 0; j < board.GetLength(1); j++)
                {
                    switch (board[i, j].Type)
                    {
                        case "Corner":
                        {
                            CreateCornerTile(form, i, j);
                            break;
                        }
                        case "Chance":
                        {
                            CreateBonusTile(form, i, j);
                            break;
                        }
                        case "Comunity Chest":
                        {
                            CreateBonusTile(form, i, j);
                            break;
                        }
                        case "Tax":
                        {
                            CreateTaxTile(form, i, j);
                            break;
                        }
                        case "Station":
                        {
                            CreateStationTile(form, i, j);
                            break;
                        }
                        case "Utility":
                        {
                            CreateUtilityTile(form, i, j);
                            break;
                        }
                        case "Property":
                        {
                            CreatePropertyTile(form, i, j);
                            break;
                        }
                    }

                    int[] position = GetTileLocation(i, j);
                    board[i, j].WorldPosition = new Point(position[0], position[1]);
                    Debug.Print(Severity.Info, board[i, j].Name + ": " + board[i, j].WorldPosition);
                }
            }
        }
        
        #region Create Tile Functions

        private void CreateCornerTile(Form form, int i, int j)
        {
            CornerControl cornerControl = new CornerControl();
            cornerControl.oPicture.Image = File.GetImageFromName(board[i, j].Name + ".png");

            int[] position = GetTileLocation(i, j);;
            cornerControl.Location = new Point(position[0], position[1]);

            form.Controls.Add(cornerControl);
            if (board[i, j].Name.Trim() == "Go") StartPoint = cornerControl.Location;
        }

        private void CreateBonusTile(Form form, int i, int j)
        {
            BonusControl chanceControl = new BonusControl();
            chanceControl.lblName.Text = board[i, j].Name;
            chanceControl.oPicture.Image = File.GetImageFromName(board[i, j].Name + ".png");

            int[] position = GetTileLocation(i, j);;
            chanceControl.Location = new Point(position[0], position[1]);

            chanceControl.Chest = true;
            form.Controls.Add(chanceControl);
        }

        private void CreateTaxTile(Form form, int i, int j)
        {
            ExtraControl extraControl = new ExtraControl();
            extraControl.lblName.Text = board[i, j].Name;
            extraControl.oPicture.Image = File.GetImageFromName(board[i, j].Name + ".png");
            extraControl.lblPrice.Text = "Pay " + board[i, j].Price.ToString();

            int[] position = GetTileLocation(i, j); ;
            extraControl.Location = new Point(position[0], position[1]);

            form.Controls.Add(extraControl);
        }

        private void CreateStationTile(Form form, int i, int j)
        {
            ExtraControl extraControl = new ExtraControl();
            extraControl.lblName.Text = board[i, j].Name;
            extraControl.oPicture.Image = File.GetImageFromName(board[i, j].Type + ".png");
            extraControl.lblPrice.Text = board[i, j].Price.ToString();

            int[] position = GetTileLocation(i, j); ;
            extraControl.Location = new Point(position[0], position[1]);

            form.Controls.Add(extraControl);
        }

        private void CreateUtilityTile(Form form, int i, int j)
        {
            ExtraControl extraControl = new ExtraControl();
            extraControl.lblName.Text = board[i, j].Name;
            extraControl.oPicture.Image = File.GetImageFromName(board[i, j].Name + ".png");
            extraControl.lblPrice.Text = board[i, j].Price.ToString();

            int[] position = GetTileLocation(i, j); ;
            extraControl.Location = new Point(position[0], position[1]);

            form.Controls.Add(extraControl);
        }

        private void CreatePropertyTile(Form form, int i, int j)
        {
            PropertyControl propertyControl = new PropertyControl();
            propertyControl.lblName.Text = board[i, j].Name;
            propertyControl.lblPrice.Text = board[i, j].Price.ToString();
            propertyControl.oPropColor.BackColor = board[i, j].Color;

            int[] position = GetTileLocation(i, j); ;
            propertyControl.Location = new Point(position[0], position[1]);

            form.Controls.Add(propertyControl);
        }

        #endregion

        public int[] GetTileLocation(int i, int j)
        {
            int x = 0, y = 0;

            switch (i)
            {
                case 0:
                    x = ((board.GetLength(1) - j) * PropertySize + PropertySize);
                    y = ((board.GetLength(1)) * PropertySize) + PropertySize;
                    break;
                case 1:
                    x = PropertySize;
                    y = ((board.GetLength(1) - j) * PropertySize + PropertySize);
                    break;
                case 2:
                    x = j * PropertySize + PropertySize;
                    y = PropertySize;
                    break;
                case 3:
                    x = ((board.GetLength(1)) * PropertySize + PropertySize);
                    y = (j * PropertySize) + PropertySize;
                    break;
                default:
                    break;
            }

            return new int[2]{x - PropertySize, y - PropertySize};
        }

        public static Board LoadBoard()
        {
            return new Board(File.LoadBoard("board.csv"));
        }

        public Property GetProperty(Point position)
        {
            return board[position.X, position.Y];
        }
    }
}