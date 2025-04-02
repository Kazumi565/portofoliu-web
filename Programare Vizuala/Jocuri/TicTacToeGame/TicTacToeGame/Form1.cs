using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        Player currentPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        public enum Player
        {
            X,
            O
        }

        private void buttonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.LightGreen;
            Check();
            AiTimer.Start();
        }

        private void playAI(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Text == "?" && x.Enabled)
                {
                    x.Enabled = false;
                    currentPlayer = Player.O;
                    x.Text = currentPlayer.ToString();
                    x.BackColor = Color.LightGoldenrodYellow;
                    AiTimer.Stop();
                    Check();
                    break;
                }
            }
        }

        private void Check()
        {
            if (Win("X"))
            {
                label1.Text = "X Wins";
                HighlightWinningLine("X");
                WON();
            }
            else if (Win("O"))
            {
                label1.Text = "O Wins";
                HighlightWinningLine("O");
                WON();
            }
            else if (AllButtonsFilled())
            {
                label1.Text = "Remiză!";
                WON();
            }
        }

        private void HighlightWinningLine(string symbol)
        {
            Button[] b = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            // Horizontal
            if (b[0].Text == symbol && b[1].Text == symbol && b[2].Text == symbol)
                Highlight(b[0], b[1], b[2]);
            else if (b[3].Text == symbol && b[4].Text == symbol && b[5].Text == symbol)
                Highlight(b[3], b[4], b[5]);
            else if (b[6].Text == symbol && b[7].Text == symbol && b[8].Text == symbol)
                Highlight(b[6], b[7], b[8]);

            // Vertical
            else if (b[0].Text == symbol && b[3].Text == symbol && b[6].Text == symbol)
                Highlight(b[0], b[3], b[6]);
            else if (b[1].Text == symbol && b[4].Text == symbol && b[7].Text == symbol)
                Highlight(b[1], b[4], b[7]);
            else if (b[2].Text == symbol && b[5].Text == symbol && b[8].Text == symbol)
                Highlight(b[2], b[5], b[8]);

            // Diagonal
            else if (b[0].Text == symbol && b[4].Text == symbol && b[8].Text == symbol)
                Highlight(b[0], b[4], b[8]);
            else if (b[2].Text == symbol && b[4].Text == symbol && b[6].Text == symbol)
                Highlight(b[2], b[4], b[6]);
        }

        private bool AllButtonsFilled()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag != null && x.Tag.ToString() == "play" && x.Text == "?")
                {
                    return false;
                }
            }
            return true;
        }


        private void Highlight(Button a, Button b, Button c)
        {
            a.BackColor = b.BackColor = c.BackColor = Color.Yellow;
        }



        private bool Win(string symbol)
        {
            return
                (button1.Text == symbol && button2.Text == symbol && button3.Text == symbol) ||
                (button4.Text == symbol && button5.Text == symbol && button6.Text == symbol) ||
                (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol) ||
                (button1.Text == symbol && button4.Text == symbol && button7.Text == symbol) ||
                (button2.Text == symbol && button5.Text == symbol && button8.Text == symbol) ||
                (button3.Text == symbol && button6.Text == symbol && button9.Text == symbol) ||
                (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol) ||
                (button3.Text == symbol && button5.Text == symbol && button7.Text == symbol);
        }

        private void WON()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag != null && x.Tag.ToString() == "play")
                {
                    ((Button)x).Enabled = false;
                }
            }
        }

        private void resetGame(object sender, EventArgs e)
        {
            label1.Text = "??";
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag != null && x.Tag.ToString() == "play")
                {
                    x.Enabled = true;
                    x.Text = "?";
                    x.BackColor = DefaultBackColor;
                }
            }
        }
    }
}
