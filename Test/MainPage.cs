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
    public partial class MainPage : Form
    {
        BlackjackPage playBlackjack = new BlackjackPage();

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPlayBlackjack_Click(object sender, EventArgs e)
        {
            playBlackjack.Show();
        }
    }
}
