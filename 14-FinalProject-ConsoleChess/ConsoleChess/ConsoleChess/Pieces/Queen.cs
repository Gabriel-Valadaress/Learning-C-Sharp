using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class Queen : Piece
{
    public Queen(string name, string color, Position position) : base(name, color, position) { }

    public override List<Position> PossibleMovement(Piece[] pieces)
    {
        List<Position> possibleMovement = new List<Position>();

        for (int i = 1; i < 8; i++)
        {
            if (Position.Row + i > 8 || Position.Column + i > 8)
            {
                break;
            }
            if (pieces[((Position.Row + i) - 1) * 8 + ((Position.Column + i) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row + i, Position.Column + i));
            }
            else
            {
                break;
            }
        }

        for (int i = 1; i < 8; i++)
        {
            if (Position.Row + i > 8 || Position.Column - i < 1)
            {
                break;
            }
            if (pieces[((Position.Row + i) - 1) * 8 + ((Position.Column - i) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row + i, Position.Column - i));
            }
            else
            {
                break;
            }
        }

        for (int i = 1; i < 8; i++)
        {
            if (Position.Row - i < 1 || Position.Column + i > 8)
            {
                break;
            }
            if (pieces[((Position.Row - i) - 1) * 8 + ((Position.Column + i) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row - i, Position.Column + i));
            }
            else
            {
                break;
            }
        }

        for (int i = 1; i < 8; i++)
        {
            if (Position.Row - i < 1 || Position.Column - i < 1)
            {
                break;
            }
            if (pieces[((Position.Row - i) - 1) * 8 + ((Position.Column - i) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row - i, Position.Column - i));
            }
            else
            {
                break;
            }
        }

        for (int i = 1; i < 8; i++)
        {
            if (Position.Row + i > 8)
            {
                break;
            }
            if (pieces[((Position.Row + i) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row + i, Position.Column));
            }
            else
            {
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
                possibleMovement.Add(new Position(Position.Row - i, Position.Column));
            }
            else
            {
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
                possibleMovement.Add(new Position(Position.Row, Position.Column + i));
            }
            else
            {
                break;
            }
        }
        
        for (int i = 1; i < 8; i++)
        {
            if (Position.Column - i > 8)
            {
                break;
            }
            if (pieces[(Position.Row - 1) * 8 + ((Position.Column - i) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row, Position.Column - i));
            }
            else
            {
                break;
            }
        }

        return possibleMovement;
    }
}
