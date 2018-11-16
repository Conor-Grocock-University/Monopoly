using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Monopoly.Controls;
using Monopoly.Utility;

namespace Monopoly
{
    public class Board
    {
        public Property[,] board;
        public Point StartPoint;

        private Board(Property[,] board)
        {
            this.board = board;
        }

        private readonly int PropertySize = 90;
        public void Draw(Form form)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j].Type == "Corner")
                    {
                        CreateCornerTile(form, i, j);
                    }
                    if (board[i, j].Type == "Chance")
                    {
                        CreateBonusTile(form, i, j);
                    }
                    if (board[i, j].Type == "Comunity Chest")
                    {
                        CreateBonusTile(form, i, j);
                    }
                    if (board[i, j].Type == "Tax")
                    {
                        CreateTaxTile(form, i, j);
                    }
                    if (board[i, j].Type == "Station")
                    {
                        CreateStationTile(form, i, j);
                    }
                    if (board[i, j].Type == "Utility")
                    {
                        CreateUtilityTile(form, i, j);
                    }
                    if (board[i, j].Type == "Property")
                    {
                        CreatePropertyTile(form, i, j);
                    }

                    board[i, j].WorldPosition = getTileLocation(i, j);
                    Console.WriteLine(board[i, j].Name +": "+ board[i, j].WorldPosition);
                }
            }
        }

        #region Create Tile Functions

        private void CreateCornerTile(Form form, int i, int j)
        {
            CornerControl cornerControl = new CornerControl();
            cornerControl.oPicture.Image = File.getImageFromName(board[i, j].Name + ".png");
            cornerControl.Location = getTileLocation(i, j);
            form.Controls.Add(cornerControl);
            if (board[i, j].Name.Trim() == "Go") StartPoint = cornerControl.Location;
        }

        private void CreateBonusTile(Form form, int i, int j)
        {
            BonusControl chanceControl = new BonusControl();
            chanceControl.lblName.Text = board[i, j].Name;
            chanceControl.oPicture.Image = File.getImageFromName(board[i, j].Name + ".png");
            chanceControl.Location = getTileLocation(i, j);
            chanceControl.Chest = true;
            form.Controls.Add(chanceControl);
        }

        private void CreateTaxTile(Form form, int i, int j)
        {
            ExtraControl extraControl = new ExtraControl();
            extraControl.lblName.Text = board[i, j].Name;
            extraControl.oPicture.Image = File.getImageFromName(board[i, j].Name + ".png");
            extraControl.lblPrice.Text = "Pay " + board[i, j].Price.ToString();
            extraControl.Location = getTileLocation(i, j);
            form.Controls.Add(extraControl);
        }

        private void CreateStationTile(Form form, int i, int j)
        {
            ExtraControl extraControl = new ExtraControl();
            extraControl.lblName.Text = board[i, j].Name;
            extraControl.oPicture.Image = File.getImageFromName(board[i, j].Type + ".png");
            extraControl.lblPrice.Text = board[i, j].Price.ToString();
            extraControl.Location = getTileLocation(i, j);
            form.Controls.Add(extraControl);
        }

        private void CreateUtilityTile(Form form, int i, int j)
        {
            ExtraControl extraControl = new ExtraControl();
            extraControl.lblName.Text = board[i, j].Name;
            extraControl.oPicture.Image = File.getImageFromName(board[i, j].Name + ".png");
            extraControl.lblPrice.Text = board[i, j].Price.ToString();
            extraControl.Location = getTileLocation(i, j);
            form.Controls.Add(extraControl);
        }

        private void CreatePropertyTile(Form form, int i, int j)
        {
            PropertyControl propertyControl = new PropertyControl();
            propertyControl.lblName.Text = board[i, j].Name;
            propertyControl.lblPrice.Text = board[i, j].Price.ToString();
            propertyControl.oPropColor.BackColor = board[i, j].Color;
            propertyControl.Location = getTileLocation(i, j);
            form.Controls.Add(propertyControl);
        }

        private Point getTileLocation(int i, int j)
        {
            int x = 0;
            int y = 0;
            int t = 0;

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
            }

            return new Point(x - PropertySize, y - PropertySize);

        }

        #endregion

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