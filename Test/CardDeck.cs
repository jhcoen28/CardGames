using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Test
{
    public class CardDeck
    {
        PlayingCard[] deck = new PlayingCard[52];
        private int topIndex = -1;
        Random random = new Random();
        string path = "c:\\users\\justin\\documents\\visual studio 2015\\Projects\\Test\\Test\\obj\\Playing Cards\\Cards";
        string[][] cardImages = new string[4][];

        public CardDeck()
        {
            getCardImages();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    topIndex++;
                    deck[topIndex] = new PlayingCard(i, j, cardImages[i-1][j-1]);
                }
            }
        }

        public void getCardImages()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        cardImages[i] = Directory.GetFiles((path + "\\Clubs"), "*.png").OrderBy(f => f.Length).ToArray();
                        break;
                    case 1:
                        cardImages[i] = Directory.GetFiles((path + "\\Spades"), "*.png").OrderBy(f => f.Length).ToArray();
                        break;
                    case 2:
                        cardImages[i] = Directory.GetFiles((path + "\\Hearts"), "*.png").OrderBy(f => f.Length).ToArray();
                        break;
                    case 3:
                        cardImages[i] = Directory.GetFiles((path + "\\Diamonds"), "*.png").OrderBy(f => f.Length).ToArray();
                        break;
                }
            }
            
        }



        public int getTop()
        {
            return topIndex;
        }

        public PlayingCard Draw()
        {
            PlayingCard temp;
            temp = deck[topIndex];
            deck[topIndex] = null;
            topIndex--;
            return temp;
        }

        public void ReturnCard(PlayingCard card)
        {
            topIndex++;
            deck[topIndex] = card;
        }

        // http://rosettacode.org/wiki/Knuth_shuffle
        public void Shuffle()
        {
            for (int i = 0; i < deck.Length; i++)
            {
                int j = random.Next(i, deck.Length); // Don't select from the entire array on subsequent loops
                PlayingCard temp = deck[i]; deck[i] = deck[j]; deck[j] = temp;
            }
        }
    }
}
