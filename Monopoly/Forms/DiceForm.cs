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
        public static DiceForm Instance;
        public DiceForm()
        {
            InitializeComponent();
            Instance = this;
            RollDice();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void RollDice()
        {
            Random r = new Random();
            int d1 = r.Next(1, 6);
            int d2 = r.Next(1, 6);

            oDice1.Image = File.GetImageFromName("Dice/" + d1.ToString() + ".png");
            oDice2.Image = File.GetImageFromName("Dice/" + d2.ToString() + ".png");

        }
    }
}
