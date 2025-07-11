using System;
using ConsoleChess.Board;
using System.Linq;

namespace ConsoleChess.Pieces;

public class Knight : Piece
{
    public Knight(string name, string color, Position position) : base(name, color, position) { }

    public override List<Position> PossibleMovement(Piece[] pieces, int turnCount)
    {
        List<Position> possibleMovement = new List<Position>();

        if (Position.Row + 2 < 9 && Position.Column + 1 < 9)
        {
            if (pieces[((Position.Row + 2) - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row + 2, Position.Column + 1));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row + 2) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row + 2, Position.Column + 1));
                }
            }
            else
            {
                if (pieces[((Position.Row + 2) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row + 2, Position.Column + 1));
                }
            }
        }
        if (Position.Row + 2 < 9 && Position.Column - 1 > 0)
        {
            if (pieces[((Position.Row + 2) - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row + 2, Position.Column - 1));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row + 2) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row + 2, Position.Column - 1));
                }
            }
            else
            {
                if (pieces[((Position.Row + 2) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row + 2, Position.Column - 1));
                }
            }
        }
        if (Position.Row - 2 > 0 && Position.Column + 1 < 9)
        {
            if (pieces[((Position.Row - 2) - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row - 2, Position.Column + 1));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row - 2) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row - 2, Position.Column + 1));
                }
            }
            else
            {
                if (pieces[((Position.Row - 2) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row - 2, Position.Column + 1));
                }
            }
        }
        if (Position.Row - 2 > 0 && Position.Column - 1 > 0)
        {
            if (pieces[((Position.Row - 2) - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row - 2, Position.Column - 1));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row - 2) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row - 2, Position.Column - 1));
                }
            }
            else
            {
                if (pieces[((Position.Row - 2) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row - 2, Position.Column - 1));
                }
            }
        }
        if (Position.Row + 1 < 9 && Position.Column + 2 < 9)
        {
            if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 2) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row + 1, Position.Column + 2));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 2) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row + 1, Position.Column + 2));
                }
            }
            else
            {
                if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 2) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row + 1, Position.Column + 2));
                }
            }
        }
        if (Position.Row - 1 > 0 && Position.Column + 2 < 9)
        {
            if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 2) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row - 1, Position.Column + 2));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 2) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row - 1, Position.Column + 2));
                }
            }
            else
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 2) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row -1, Position.Column + 2));
                }
            }
        }
        if (Position.Row + 1 < 9 && Position.Column - 2 > 0)
        {
            if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 2) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row + 1, Position.Column - 2));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 2) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row + 1, Position.Column - 2));
                }
            }
            else
            {
                if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 2) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row + 1, Position.Column - 2));
                }
            }
            
        }
        if (Position.Row - 1 > 0 && Position.Column - 2 > 0)
        {
            if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 2) - 1)].Name == "-")
            {
                possibleMovement.Add(new Position(Position.Row - 1, Position.Column - 2));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 2) - 1)].Color == "Black")
                {
                    possibleMovement.Add(new Position(Position.Row - 1, Position.Column - 2));
                }
            }
            else
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 2) - 1)].Color == "White")
                {
                    possibleMovement.Add(new Position(Position.Row - 1, Position.Column - 2));
                }
            }
        }

        return possibleMovement;
    }
}
