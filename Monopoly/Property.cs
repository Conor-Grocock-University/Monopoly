using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Property
    {
        private int cardId;
        private string type;
        private string name;
        private Color color;
        private int price;

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

        public Property(int cardId, string type, string name, Color color, int price)
        {
            this.cardId = cardId;
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.color = color;
            this.price = price;
        }
    }
}
