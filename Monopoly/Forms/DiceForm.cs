using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monopoly.Utility;

namespace Monopoly.Forms
{
    public partial class DiceForm : Form
    {
        public static DiceForm instance;
        public DiceForm()
        {
            InitializeComponent();
            instance = this;
            RollDice();

            btnRoll.Enabled = false;
            GlobalStorage.OnNextPlayerTurn += player => btnRoll.Enabled = true;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            RollDice();
            btnRoll.Enabled = false;
            GlobalStorage.OnDiceRollComplete();
        }

        private void RollDice()
        {
            Random r = new Random();
            int d1 = r.Next(1, 6);
            int d2 = r.Next(1, 6);

            oDice1.Image = File.getImageFromName("Dice/" + d1.ToString() + ".png");
            oDice2.Image = File.getImageFromName("Dice/" + d2.ToString() + ".png");

            GlobalStorage.dice[0] = d1;
            GlobalStorage.dice[1] = d2;

        }
    }
}
