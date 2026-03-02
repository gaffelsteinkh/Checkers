using System;

namespace Checkers.Models;

public class GameState
{
    public Board Board { get; set; } = new Board();
    public PieceColor CurrentTurn { get; set; } = PieceColor.Red;
}