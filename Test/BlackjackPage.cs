using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class BlackjackPage : Form
    {
        Player[] players = new Player[2];
        Blackjack blackjack;
        List<PictureBox> dealerCardPctBox = new List<PictureBox>();
        List<PictureBox> playerCardPctBox = new List<PictureBox>();

        public BlackjackPage()
        {
            InitializeComponent();
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {
            initializePlayers();
            dealerCardPctBox.Add(picDealerFaceDown);
            dealerCardPctBox.Add(picDealerFaceUp);
            playerCardPctBox.Add(picPlayerCard1);
            playerCardPctBox.Add(picPlayerCard2);

            blackjack = new Blackjack(players);
            blackjack.playBlackjack();

            for (int j = 0; j < players[0].hand.Count(); j++)
            {
                dealerCardPctBox[j].Image = players[0].hand[j].cardImage;
                dealerCardPctBox[j].SizeMode = PictureBoxSizeMode.StretchImage;
            }

            for (int j = 0; j < players[1].hand.Count(); j++)
            {
                playerCardPctBox[j].Image = players[1].hand[j].cardImage;
                playerCardPctBox[j].SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void initializePlayers()
        {
            for (int i = 0; i < players.Count(); i++)
            {
                players[i] = new Player();
            }
        }

    }
}
