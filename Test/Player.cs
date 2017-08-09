using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Player
    {
        public PlayingCard[] hand;
        public int topIndex = -1;
        public string name;
        public CardDeck deck;
        public static PlayingCard[] tempArray = new PlayingCard[14];

        public Player()
        {
            hand = new PlayingCard[2];
        }

        public void AddCard(PlayingCard Card)
        {
            topIndex++;
            hand[topIndex] = Card;
        }

        public int NumCardsInHand()
        {
            return topIndex;
        }

        //public void ReturnHandToDeck()
        //{
        //    for (int i = 0; i <= topIndex; i++)
        //    {
        //        deck.ReturnCard(hand[i]);
        //        hand[i] = null;
        //    }
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(name + ": ");

            for (int i = 0; i <= topIndex; i++)
            {
                sb.Append(hand[i].ToString() + " ");
            }

            return sb.ToString();
        }
    }
}
