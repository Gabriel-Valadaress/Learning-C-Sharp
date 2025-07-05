using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class Pawn : Piece
{
    public Pawn(string name, string color, Position position) : base(name, color, position) { }

    public List<Position> PossibleMovement()
    {
        List<Position> possibleMovement = new List<Position>();

        if (Color == "White")
        {
            if (Position.Row == 2)
            {
                possibleMovement.Add(new Position(Position.Row + 2, Position.Column));
            }
            possibleMovement.Add(new Position(Position.Row + 1, Position.Column));
            
        }

        if (Color == "Black")
        {
            if (Position.Row == 7)
            {
                possibleMovement.Add(new Position(Position.Row - 2, Position.Column));
            }
            possibleMovement.Add(new Position(Position.Row - 1, Position.Column));
            
        }

        return possibleMovement;
    }
}
