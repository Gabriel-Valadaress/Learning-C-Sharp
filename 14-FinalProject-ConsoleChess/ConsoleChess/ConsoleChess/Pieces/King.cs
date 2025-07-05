using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class King : Piece
{
    public King (string name, string color, Position position) : base(name, color, position) { }

    public List<Position> PossibleMovement()
    {
        List<Position> possibleMovement = new List<Position>();

        if (Position.Row > 1)
        {
            possibleMovement.Add(new Position(Position.Row - 1, Position.Column));

            if (Position.Column > 1)
            {
                possibleMovement.Add(new Position(Position.Row, Position.Column - 1));
                possibleMovement.Add(new Position(Position.Row - 1, Position.Column - 1));
            }

            if (Position.Column < 8)
            {
                possibleMovement.Add(new Position(Position.Row, Position.Column + 1));
                possibleMovement.Add(new Position(Position.Row - 1, Position.Column + 1));
            }

            if (Position.Row < 8)
            {
                if (Position.Column > 1)
                {
                    possibleMovement.Add(new Position(Position.Row + 1, Position.Column - 1));
                }

                if (Position.Column < 8)
                {
                    possibleMovement.Add(new Position(Position.Row + 1, Position.Column + 1));
                }
                possibleMovement.Add(new Position(Position.Row + 1, Position.Column));
            }
        }
        else
        {
            possibleMovement.Add(new Position(Position.Row + 1, Position.Column));

            if (Position.Column > 1)
            {
                possibleMovement.Add(new Position(Position.Row, Position.Column - 1));
                possibleMovement.Add(new Position(Position.Row + 1, Position.Column - 1));
            }

            if (Position.Column < 8)
            {
                possibleMovement.Add(new Position(Position.Row, Position.Column + 1));
                possibleMovement.Add(new Position(Position.Row + 1, Position.Column + 1));
            }
        }

        return possibleMovement;
    }
}
