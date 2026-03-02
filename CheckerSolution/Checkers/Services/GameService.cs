using System;
using Checkers.Models;

namespace Checkers.Services;

public class GameService
{
    public GameState CreateGame()
    {
        var state = new GameState();

        InitializeBoard(state.Board);

        return state;
    }

    private void InitializeBoard(Board board)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if ((row + col) % 2 == 1)
                {
                    board.Squares[row, col] = new Piece { Color = PieceColor.Black };
                }
            }
        }

        for (int row = 5; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if ((row + col) % 2 == 1)
                {
                    board.Squares[row, col] = new Piece { Color = PieceColor.Red };
                }
            }
        }
    }
}