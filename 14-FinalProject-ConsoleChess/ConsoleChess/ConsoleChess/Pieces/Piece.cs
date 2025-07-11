using System;
using ConsoleChess.Board;

namespace ConsoleChess.Pieces;

public class Piece
{
    public string Name { get; set; }
    public string Color { get; set; }
    public Position Position { get; set; }
    public bool InitialPosition { get; set; } = true;
    public int TurnOfLastMovement { get; set; } = 0;

    public Piece(string name, string color, Position position)
    {
        Name = name;
        Color = color;
        Position = position;
    }
    public virtual List<Position> PossibleMovement(Piece[] pieces, int turnCount)
    {
        return new List<Position>();
    }
}
