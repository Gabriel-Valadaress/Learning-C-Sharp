using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class Knight : Piece
{
    public Knight(string name, string color, Position position) : base(name, color, position) { }

    public List<Position> PossibleMovement()
    {
        List<Position> possibleMovement = new List<Position>();

        if (Color == "White")
        {
        }

        return possibleMovement;
    }
}
