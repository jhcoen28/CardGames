using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Test
{
    public class PlayingCard
    {
        public int rank { get; set; }
        public CardSuit suit { get; set; }
        public Image cardImage { get; set; }

        public PlayingCard(int suit, int rank, string cardImage)
        {
            this.rank = rank;
            this.suit = (CardSuit)suit;
            this.cardImage = Image.FromFile(cardImage);
        }

        public override string ToString()
        {
            switch (rank)
            {
                case 1:
                    return (suit.ToString() + 'A');
                case 11:
                    return (suit.ToString() + 'J');
                case 12:
                    return (suit.ToString() + 'Q');
                case 13:
                    return (suit.ToString() + 'K');
                default:
                    return (suit.ToString() + rank.ToString());
            }
        }

        public enum CardSuit
        {
            C = 1,
            S,
            H,
            D
        }
    }
}
