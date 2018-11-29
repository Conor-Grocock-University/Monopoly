using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Forms;
using Monopoly.Utility;
using Debug = Monopoly.Utility.Debug;

namespace Monopoly.Models
{
    public class Property
    {
        private int cardId;
        private string type;
        private string name;
        private Color color;
        private int price;
        private bool canBePurchased;

        public Player Owner;

        public Point WorldPosition;

        public int CardId
        {
            get { return cardId; }
        }
        public string Type
        {
            get { return type; }
        }
        public string Name
        {
            get { return name; }
        }
        public Color Color
        {
            get { return color; }
        }
        public int Price
        {
            get { return price; }
        }
        public bool CanBePurchased
        {
            get { return canBePurchased; }
        }

        public int RentPrice;
        public int propertyStage = 0;


        public Property(int cardId, string type, string name, Color color, int price, bool canBePurchased, int RentPrice)
        {
            this.cardId = cardId;
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.color = color;
            this.price = price;
            this.canBePurchased = canBePurchased;
            this.RentPrice = RentPrice;
        }

        public bool CanBuy(Player player)
        {
            if (Owner != null) return false;
            if (!CanBePurchased) return false;

            return player.CanAfford(this);
        }

        public void Purchase(Player player)
        {
            this.Owner = player;
        }
        
        public void increasePropertyStage()
        {
            //propertyStage++;
        }

        public void LandAction(Board board, Player player)
        {
            Debug.Print(Severity.Error, type);
            switch (type)
            {
                case "Tax":
                    player.SetBalance(price);
                    break;
                case "Station":
                    player.SetBalance(board.StationsOwned() * 25);
                    break;
                case "Utility":
                    if(board.UtilitysOwned() == 1) player.SetBalance(4 * DiceForm.Instance.dTotal);
                    else if (board.UtilitysOwned() == 2) player.SetBalance(10 * DiceForm.Instance.dTotal);
                    break;
                case "Property":
                    player.SetBalance(this.RentPrice);
                    break;
                case "Corner":
                    Debug.Print(Severity.Error, name.ToLower().Trim());
                    if(name.ToLower().Trim() == "go to jail") player.GoToJail(board);
                    break;
            }
        }
    }
}
