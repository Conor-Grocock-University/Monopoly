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
        private readonly Property[,] _board;

        private readonly Player[] _players = new Player[4];
        public readonly PlayerVisualGroup PlayerVisualGroup = new PlayerVisualGroup();

        private Board(Property[,] board)
        {
            this._board = board;
            CreatePlayers();
        }

        private void CreatePlayers()
        {
            for (int i = 0; i < _players.Length; i++)
            {
                _players[i] = new Player(i, this);

                PictureBox playerPictureBox = new PictureBox
                {
                    Image = File.GetImageFromName("Players/" + _players[i].Number + ".png")
                };
                var position = GetTileLocation(_players[i].Position[0], _players[i].Position[1]);
                playerPictureBox.Location = new Point(position[0], position[1]);
                playerPictureBox.Size = new Size(40, 40);

                PlayerVisualGroup.Set(i, new PlayerVisual(ref _players[i], ref playerPictureBox));
            }
        }

        private Form1 _boardForm;
        public void Draw()
        {
            _boardForm.RequestRedraw();
        }

        public const int PropertySize = 90;

        public void MoveRandomPlayer()
        {
            _players[0].Move(1);
        }

        public void DrawBoard(Form1 form)
        {
            _boardForm = form;
            for (var i = 0; i < _board.GetLength(0); i++)
            {
                for (var j = 0; j < _board.GetLength(1); j++)
                {
                    switch (_board[i, j].Type)
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
                        case "Community Chest":
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
                        default:
                        {
                            Debug.Print(Severity.Warn, "Unknown tile type: " + _board[i, j].Type);
                            break;
                        }
                    }

                    int[] position = GetTileLocation(i, j);
                    _board[i, j].WorldPosition = new Point(position[0], position[1]);
                    Debug.Print(Severity.Info, _board[i, j].Name + ": " + _board[i, j].WorldPosition);
                }
            }
        }
        
        #region Create Tile Functions

        private void CreateCornerTile(Form form, int i, int j)
        {
            CornerControl cornerControl = new CornerControl();
            cornerControl.oPicture.Image = File.GetImageFromName(_board[i, j].Name + ".png");

            int[] position = GetTileLocation(i, j);;
            cornerControl.Location = new Point(position[0], position[1]);

            form.Controls.Add(cornerControl);
            if (_board[i, j].Name.Trim() == "Go")
            {
            }
        }

        private void CreateBonusTile(Form form, int i, int j)
        {
            BonusControl chanceControl = new BonusControl();
            chanceControl.lblName.Text = _board[i, j].Name;
            chanceControl.oPicture.Image = File.GetImageFromName((_board[i, j].Name + ".png").Replace(' ', '_'));

            int[] position = GetTileLocation(i, j);;
            chanceControl.Location = new Point(position[0], position[1]);

            chanceControl.Chest = true;
            form.Controls.Add(chanceControl);
        }

        private void CreateTaxTile(Form form, int i, int j)
        {
            ExtraControl extraControl = new ExtraControl();
            extraControl.lblName.Text = _board[i, j].Name;
            extraControl.oPicture.Image = File.GetImageFromName(_board[i, j].Name + ".png");
            extraControl.lblPrice.Text = "Pay " + _board[i, j].Price.ToString();

            int[] position = GetTileLocation(i, j); ;
            extraControl.Location = new Point(position[0], position[1]);

            form.Controls.Add(extraControl);
        }

        private void CreateStationTile(Form form, int i, int j)
        {
            ExtraControl extraControl = new ExtraControl();
            extraControl.lblName.Text = _board[i, j].Name;
            extraControl.oPicture.Image = File.GetImageFromName(_board[i, j].Type + ".png");
            extraControl.lblPrice.Text = _board[i, j].Price.ToString();

            int[] position = GetTileLocation(i, j); ;
            extraControl.Location = new Point(position[0], position[1]);

            form.Controls.Add(extraControl);
        }

        private void CreateUtilityTile(Form form, int i, int j)
        {
            ExtraControl extraControl = new ExtraControl();
            extraControl.lblName.Text = _board[i, j].Name;
            extraControl.oPicture.Image = File.GetImageFromName(_board[i, j].Name + ".png");
            extraControl.lblPrice.Text = _board[i, j].Price.ToString();

            int[] position = GetTileLocation(i, j); ;
            extraControl.Location = new Point(position[0], position[1]);

            form.Controls.Add(extraControl);
        }

        private void CreatePropertyTile(Form form, int i, int j)
        {
            PropertyControl propertyControl = new PropertyControl();
            propertyControl.lblName.Text = _board[i, j].Name;
            propertyControl.lblPrice.Text = _board[i, j].Price.ToString();
            propertyControl.oPropColor.BackColor = _board[i, j].Color;

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
                    x = ((_board.GetLength(1) - j) * PropertySize + PropertySize);
                    y = ((_board.GetLength(1)) * PropertySize) + PropertySize;
                    break;
                case 1:
                    x = PropertySize;
                    y = ((_board.GetLength(1) - j) * PropertySize + PropertySize);
                    break;
                case 2:
                    x = j * PropertySize + PropertySize;
                    y = PropertySize;
                    break;
                case 3:
                    x = ((_board.GetLength(1)) * PropertySize + PropertySize);
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
            return _board[position.X, position.Y];
        }
    }
}