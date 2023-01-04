using System.Runtime.CompilerServices;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        const int ROW = 3;
        const int COL = 3;
        string[,] board = new string[ROW, COL];
        
        bool turn = false; //false = O turn ; true = X turn
        bool PlayerWon = false;

        int x_win = 0;
        int o_win = 0;
        int availableSpaces = ROW * COL;


        public Form1()
        {
            InitializeComponent();

            if (turn)
            {
                TurnLabel.Text = "Turn: O";
            }
            else
            {
                TurnLabel.Text = "Turn: X";
            }
            turn = !turn;

        }

        public void Setup_and_Update_Board()
        {
            board[0, 0] = R1C1.Text;
            board[0, 1] = R1C2.Text;
            board[0, 2] = R1C3.Text;

            board[1, 0] = R2C1.Text;
            board[1, 1] = R2C2.Text;
            board[1, 2] = R2C3.Text;

            board[2, 0] = R3C1.Text;
            board[2, 1] = R3C2.Text;
            board[2, 2] = R3C3.Text;

            for (int x = 0; x < COL; x++)
            {
                for (int y = 0; y < ROW; y++)
                {
                    if (board[x, y] == "X" || board[x, y] == "O")
                    {
                        board[x, y] = board[x, y];
                    }
                    else
                    {
                        board[x, y] = "*";
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (PlayerWon)
            {
                return;
            }

            Button b = (Button)sender;

            if (turn)
            {
                b.Text = "X";
                TurnLabel.Text = "Turn: O";
            }
            else
            {
                b.Text = "O";
                TurnLabel.Text = "Turn: X";
            }

            availableSpaces--;
            turn = !turn;
            b.Enabled = false;


            Setup_and_Update_Board();
            check_For_win();
            Check_For_Winner();
        }


        private bool check_For_win()
        {

            // Check Rows
            for (int x = 0; x < 2; x++)
            {
                if (!board[x, 0].Equals("*"))
                {
                    if (board[x, 0] == board[x, 1] && board[x, 0] == board[x, 2])
                    {
                        PlayerWon = true;
                        return PlayerWon;
                    }
                }
            }

            // Check Columns
            for (int y = 0; y < 2; y++)
            {
                if (!board[0, y].Equals("*"))
                {
                    if (board[0, y] == board[1, y] && board[0, y] == board[2, y])
                    {
                        PlayerWon = true;
                        return PlayerWon;
                    }
                }
            }

            // Check Diagonals
            if (!board[1, 1].Equals("*"))
            {
                if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] || board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
                {
                    PlayerWon = true;
                    return PlayerWon;
                }
            }
      

            return PlayerWon;
        }

        public void Check_For_Winner()
        {
            if (PlayerWon && !turn)
            {
                WinnerLabel.Text = "X WON";
                x_win++;
                X_winLabel.Text = $"X : {x_win}";
            }

            if (PlayerWon && turn)
            {
                WinnerLabel.Text = "O WON";
                o_win++;
                O_winLabel.Text = $"O : {o_win}";
            }

            if(availableSpaces == 0 && !PlayerWon)
            {
                WinnerLabel.Text = $"Tie Game";
                PlayerWon = true;
            }
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            PlayerWon = false;
            reset_board();
            reset_labels();
        }

        private void ResetAllBtn_Click(object sender, EventArgs e)
        {
            PlayerWon = false;
            reset_counters();
            reset_board();
            reset_labels();
        }

        public void reset_board()
        {
            R1C1.Text = "";
            R1C2.Text = "";
            R1C3.Text = "";

            R2C1.Text = "";
            R2C2.Text = "";
            R2C3.Text = "";

            R3C1.Text = "";
            R3C2.Text = "";
            R3C3.Text = "";

            R1C1.Enabled = true;
            R1C2.Enabled = true;
            R1C3.Enabled = true;

            R2C1.Enabled = true;
            R2C2.Enabled = true;
            R2C3.Enabled = true;

            R3C1.Enabled = true;
            R3C2.Enabled = true;
            R3C3.Enabled = true;
        }

        public void reset_counters()
        {
            x_win = 0;
            o_win = 0;
        }

        public void reset_labels()
        {
            WinnerLabel.Text = "";

            X_winLabel.Text = $"O : {x_win}";
            X_winLabel.Refresh();

            O_winLabel.Text = $"O : {o_win}";
            O_winLabel.Refresh();
        }

        //End
    }
}