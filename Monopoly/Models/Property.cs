using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Utility;

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

        private Player Owner;

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


        public Property(int cardId, string type, string name, Color color, int price, bool canBePurchased)
        {
            this.cardId = cardId;
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.color = color;
            this.price = price;
            this.canBePurchased = canBePurchased;
        }

        public bool CanBuy(Player player)
        {
            Debug.Print(Severity.Fatal, Name + " " + CanBePurchased);
            if (Owner != null) return false;
            if (!CanBePurchased) return false;

            return player.CanAfford(this);
        }

        public void Purchase(Player player)
        {
            this.Owner = player;
        }
    }
}
