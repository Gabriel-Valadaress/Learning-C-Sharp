using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class Pawn : Piece
{
    public Pawn(string name, string color, Position position) : base(name, color, position) { }

    public override List<Position> PossibleMovement(Piece[] pieces)
    {
        List<Position> possibleMovement = new List<Position>();

        if (Color == "White")
        {
            if (Position.Row == 2)
            {
                if (pieces[((Position.Row + 2) - 1) * 8 + (Position.Column - 1)].Name == "-")
                {
                    possibleMovement.Add(new Position(Position.Row + 2, Position.Column));
                }
            }

            if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row + 1, Position.Column));
            }

            if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
            {
                possibleMovement.Add(new Position(Position.Row + 1, Position.Column + 1));
            }
            
            if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
            {
                possibleMovement.Add(new Position(Position.Row + 1, Position.Column - 1));
            }
        }

        if (Color == "Black")
        {
            if (Position.Row == 7)
            {
                if (pieces[((Position.Row - 2) - 1) * 8 + (Position.Column - 1)].Name == "-")
                {
                    possibleMovement.Add(new Position(Position.Row - 2, Position.Column));
                }
            }

            if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row - 1, Position.Column));
            }
            
            if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
            {
                possibleMovement.Add(new Position(Position.Row - 1, Position.Column + 1));
            }
            
            if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
            {
                possibleMovement.Add(new Position(Position.Row - 1, Position.Column - 1));
            }
        }

        return possibleMovement;
    }
}
