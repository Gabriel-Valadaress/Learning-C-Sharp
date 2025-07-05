using System;
using ConsoleChess.Board;
using System.Linq;

namespace ConsoleChess.Pieces;

public class Knight : Piece
{
    public Knight(string name, string color, Position position) : base(name, color, position) { }

    public List<Position> PossibleMovement()
    {
        List<Position> possibleMovement = new List<Position>();

        possibleMovement.Add(new Position(Position.Row + 2, Position.Column + 1));
        possibleMovement.Add(new Position(Position.Row + 2, Position.Column - 1));
        possibleMovement.Add(new Position(Position.Row - 2, Position.Column + 1));
        possibleMovement.Add(new Position(Position.Row - 2, Position.Column - 1));
        possibleMovement.Add(new Position(Position.Row + 1, Position.Column + 2));
        possibleMovement.Add(new Position(Position.Row - 1, Position.Column + 2));
        possibleMovement.Add(new Position(Position.Row + 1, Position.Column - 2));
        possibleMovement.Add(new Position(Position.Row - 1, Position.Column - 2));

        possibleMovement.RemoveAll(p => p.Row > 8 || p.Row < 1);
        possibleMovement.RemoveAll(p => p.Column > 8 || p.Column < 1);

        return possibleMovement;
    }
}
