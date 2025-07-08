using System;
using ConsoleChess.Pieces;

namespace ConsoleChess.Board;

public class Position
{
    public int Row { get; set; }
    public int Column { get; set; }

    public Position(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public static int PositionInTheList(Position position)
    {
        return ((position.Row - 1) * 8 + position.Column - 1);
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Position))
        {
            return false;
        }
        Position other = (obj as Position)!;
        return Row.Equals(other.Row) && Column.Equals(other.Column);
    }

    override public int GetHashCode()
    {
        return Row.GetHashCode() + Column.GetHashCode();
    }
}
