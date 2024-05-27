using System;

public abstract class TicTacToeGame
{
    protected char[,] board;
    protected char currentPlayer;

    public TicTacToeGame()
    {
        board = new char[3, 3];
        currentPlayer = 'X';
        InitializeBoard();
    }

    protected void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = '_';
            }
        }
    }

    protected abstract void UpdateGameStatus();

    public void MakeMove(int row, int col)
    {
        if (board[row, col] == '_')
        {
            board[row, col] = currentPlayer;
            if (DetermineWinner() == currentPlayer)
            {
                UpdateGameStatus();
            }
            else
            {
                SwitchPlayer();
                UpdateGameStatus();
            }
        }
    }

    protected char DetermineWinner()
    {
        // Check rows and columns
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] != '_' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                return board[i, 0];
            if (board[0, i] != '_' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                return board[0, i];
        }
        // Check diagonals
        if (board[0, 0] != '_' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            return board[0, 0];
        if (board[0, 2] != '_' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            return board[0, 2];
        return '_';
    }

    protected void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }
}
