using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Blackjack
    {
        private CardDeck deck = new CardDeck();
        public Player[] players;

        public Blackjack(Player[] players)
        {
            this.players = players;
        }
        
        public void playBlackjack()
        {
            //deck.Shuffle();
            dealCards();
        }

        public void dealCards()
        {
            int totalCardsToDeal = players.Count() * 2;
            int counter = 0;

            for (int i = 0; i < totalCardsToDeal; i++)
            {
                players[counter].AddCard(deck.Draw());
                counter++;
                counter = counter % players.Count();
            }
        }
    }
}
