using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class Rook : Piece
{
    public Rook(string name, string color, Position position) : base(name, color, position) { }

    public List<Position> PossibleMovement()
    {
        List<Position> possibleMovement = new List<Position>();

        possibleMovement.Add(new Position(Position.Row + 1, Position.Column));
        possibleMovement.Add(new Position(Position.Row + 2, Position.Column));
        possibleMovement.Add(new Position(Position.Row + 3, Position.Column));
        possibleMovement.Add(new Position(Position.Row + 4, Position.Column));
        possibleMovement.Add(new Position(Position.Row + 5, Position.Column));
        possibleMovement.Add(new Position(Position.Row + 6, Position.Column));
        possibleMovement.Add(new Position(Position.Row + 7, Position.Column));
        possibleMovement.Add(new Position(Position.Row - 1, Position.Column));
        possibleMovement.Add(new Position(Position.Row - 2, Position.Column));
        possibleMovement.Add(new Position(Position.Row - 3, Position.Column));
        possibleMovement.Add(new Position(Position.Row - 4, Position.Column));
        possibleMovement.Add(new Position(Position.Row - 5, Position.Column));
        possibleMovement.Add(new Position(Position.Row - 6, Position.Column));
        possibleMovement.Add(new Position(Position.Row - 7, Position.Column));
        possibleMovement.Add(new Position(Position.Row, Position.Column + 1));
        possibleMovement.Add(new Position(Position.Row, Position.Column + 2));
        possibleMovement.Add(new Position(Position.Row, Position.Column + 3));
        possibleMovement.Add(new Position(Position.Row, Position.Column + 4));
        possibleMovement.Add(new Position(Position.Row, Position.Column + 5));
        possibleMovement.Add(new Position(Position.Row, Position.Column + 6));
        possibleMovement.Add(new Position(Position.Row, Position.Column + 7));
        possibleMovement.Add(new Position(Position.Row, Position.Column - 1));
        possibleMovement.Add(new Position(Position.Row, Position.Column - 2));
        possibleMovement.Add(new Position(Position.Row, Position.Column - 3));
        possibleMovement.Add(new Position(Position.Row, Position.Column - 4));
        possibleMovement.Add(new Position(Position.Row, Position.Column - 5));
        possibleMovement.Add(new Position(Position.Row, Position.Column - 6));
        possibleMovement.Add(new Position(Position.Row, Position.Column - 7));

        possibleMovement.RemoveAll(p => p.Row > 8 || p.Row < 1);
        possibleMovement.RemoveAll(p => p.Column > 8 || p.Column < 1);

        return possibleMovement;
    }
}
