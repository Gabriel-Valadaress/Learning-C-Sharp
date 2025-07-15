using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class Rook : Piece
{
    public Rook(string name, string color, Position position) : base(name, color, position) { }
    
    public Rook(string name, string color, Position position, bool initialPosition, int turnOfLastMovement) : base(name, color, position, initialPosition, turnOfLastMovement) { }

    public override Piece Clone()
    {
        return new Rook(Name, Color, new Position(Position.Row, Position.Column), InitialPosition, TurnOfLastMovement);
    }

    public override HashSet<int> PossibleMovement(Piece[] pieces, int turnCount)
    {
        HashSet<int> possibleMovement = new HashSet<int>();

        for (int i = 1; i < 8; i++)
        {
            if (Position.Row + i > 8)
            {
                break;
            }
            if (pieces[((Position.Row + i) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + i, Position.Column)));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row + i) - 1) * 8 + (Position.Column - 1)].Color == "Black")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + i, Position.Column)));
                }
                break;
            }
            else
            {
                if (pieces[((Position.Row + i) - 1) * 8 + (Position.Column - 1)].Color == "White")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + i, Position.Column)));
                }
                break;
            }
        }

        for (int i = 1; i < 8; i++)
        {
            if (Position.Row - i < 1)
            {
                break;
            }
            if (pieces[((Position.Row - i) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - i, Position.Column)));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row - i) - 1) * 8 + (Position.Column - 1)].Color == "Black")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - i, Position.Column)));
                }
                break;
            }
            else
            {
                if (pieces[((Position.Row - i) - 1) * 8 + (Position.Column - 1)].Color == "White")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - i, Position.Column)));
                }
                break;
            }
        }

        for (int i = 1; i < 8; i++)
        {
            if (Position.Column + i > 8)
            {
                break;
            }
            if (pieces[(Position.Row - 1) * 8 + ((Position.Column + i) - 1)].Name == "-")
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + i)));
            }
            else if (Color == "White")
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column + i) - 1)].Color == "Black")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + i)));
                }
                break;
            }
            else
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column + i) - 1)].Color == "White")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + i)));
                }
                break;
            }
        }

        for (int i = 1; i < 8; i++)
        {
            if (Position.Column - i < 1)
            {
                break;
            }
            if (pieces[(Position.Row - 1) * 8 + ((Position.Column - i) - 1)].Name == "-")
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - i)));
            }
            else if (Color == "White")
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column - i) - 1)].Color == "Black")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - i)));
                }
                break;
            }
            else
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column - i) - 1)].Color == "White")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - i)));
                }
                break;
            }
        }

        return possibleMovement;
    }
}
