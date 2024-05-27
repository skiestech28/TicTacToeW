using System;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public partial class Form1 : Form
    {
        private TicTacToeWithGUI game;

        public Form1()
        {
            InitializeComponent();
            game = new TicTacToeWithGUI(this);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null && button.Name.Length == 8)
            {
                int row = int.Parse(button.Name[6].ToString());
                int col = int.Parse(button.Name[7].ToString());

                game.MakeMove(row, col);
            }
        }

        public void UpdateBoard(char[,] board)
        {
            button00.Text = board[0, 0].ToString();
            button01.Text = board[0, 1].ToString();
            button02.Text = board[0, 2].ToString();
            button10.Text = board[1, 0].ToString();
            button11.Text = board[1, 1].ToString();
            button12.Text = board[1, 2].ToString();
            button20.Text = board[2, 0].ToString();
            button21.Text = board[2, 1].ToString();
            button22.Text = board[2, 2].ToString();
        }

        public void SetStatus(string status)
        {
            labelStatus.Text = status;
        }

        public void DisableBoard()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control.Name.StartsWith("button"))
                {
                    control.Enabled = false;
                }
            }
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            button00.Text = "";
            button01.Text = "";
            button02.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";

        }
    }
}
