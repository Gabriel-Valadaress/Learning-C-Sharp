using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class Bishop : Piece
{
    public Bishop(string name, string color, Position position) : base(name, color, position) { }

    public override List<Position> PossibleMovement(Piece[] pieces, int turnCount)
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
            else if (Color == "White")
            {
                if (pieces[((Position.Row + i) - 1) * 8 + ((Position.Column + i) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row + i, Position.Column + i));
                }
                break;
            }
            else 
            {
                if (pieces[((Position.Row + i) - 1) * 8 + ((Position.Column + i) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row + i, Position.Column + i));
                }
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
            else if (Color == "White")
            {
                if (pieces[((Position.Row + i) - 1) * 8 + ((Position.Column - i) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row + i, Position.Column - i));
                }
                break;
            }
            else
            {
                if (pieces[((Position.Row + i) - 1) * 8 + ((Position.Column - i) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row + i, Position.Column - i));
                }
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
            else if (Color == "White")
            {
                if (pieces[((Position.Row - i) - 1) * 8 + ((Position.Column + i) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row - i, Position.Column + i));
                }
                break;
            }
            else
            {
                if (pieces[((Position.Row - i) - 1) * 8 + ((Position.Column + i) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row - i, Position.Column + i));
                }
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
            else if (Color == "White")
            {
                if (pieces[((Position.Row - i) - 1) * 8 + ((Position.Column - i) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row - i, Position.Column - i));
                }
                break;
            }
            else
            {
                if (pieces[((Position.Row - i) - 1) * 8 + ((Position.Column - i) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row - i, Position.Column - i));
                }
                break;
            }
        }
        
        return possibleMovement;
    }
}
