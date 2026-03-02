using System;

namespace Checkers.Models;

public class Board
{
    public Piece?[,] Squares { get; } = new Piece?[8,8];
}