using System;
using System.Windows.Forms;
using Monopoly.Models;
using Monopoly.Visuals;

namespace Monopoly.Forms
{
    public partial class PlayerView : Form
    {
        private PlayerVisual playerVisual;
        public PlayerView()
        {
            InitializeComponent();
        }

        public PlayerView(PlayerVisual playerVisual)
        {
            InitializeComponent();
            this.playerVisual = playerVisual;

            lblPlayerName.Text = "Player " + playerVisual.Player.Number;
            lblPLayerMoney.Text = "£" + playerVisual.Player.GetBalance();
            oPlayerIcon.Image = playerVisual.pictureBox.Image;

            playerVisual.Player.OnBalanceChanged +=OnPlayerBalanceChanged;

            btnEndTurn.Enabled = false;
            btnBuyProperty.Enabled = false;
        }

        private void OnPlayerBalanceChanged()
        {
            lblPLayerMoney.Text = "£" + playerVisual.Player.GetBalance();
        }

        public Action PlayerEndTurn;
        public void AllowEndTurn()
        {
            btnEndTurn.Enabled = true;
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            btnEndTurn.Enabled = false;
            PlayerEndTurn?.Invoke();
        }

        public Action PlayerBuyProperty;

        public void AllowBuyProperty()
        {
            btnBuyProperty.Enabled = true;
        }

        private void btnBuyProperty_Click(object sender, EventArgs e)
        {
            btnBuyProperty.Enabled = false;
            PlayerBuyProperty?.Invoke();
        }

        public void AddProperty(Property property)
        {
            oProperties.Items.Add(property.Name + ": " + property.Price);
        }
    }
}
