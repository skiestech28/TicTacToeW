using TicTacToeGUI;

public class TicTacToeWithGUI : TicTacToeGame
{
    private Form1 form;

    public TicTacToeWithGUI(Form1 form)
    {
        this.form = form;
        UpdateGameStatus();
    }

    protected override void UpdateGameStatus()
    {
        form.UpdateBoard(board);
        if (DetermineWinner() != '_')
        {
            form.SetStatus($"Player {currentPlayer} wins!");
            form.DisableBoard();
        }
        else if (IsBoardFull())
        {
            form.SetStatus("It's a draw!");
            form.DisableBoard();
        }
        else
        {
            form.SetStatus($"Player {currentPlayer}'s turn");
        }
    }

    private bool IsBoardFull()
    {
        foreach (char c in board)
        {
            if (c == '_')
            {
                return false;
            }
        }
        return true;
    }
}

