using System;
using ConsoleChess.Board;
using ConsoleChess.Services;

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

    public Piece(string name, string color, Position position, bool initialPosition, int turnOfLastMovement)
    {
        Name = name;
        Color = color;
        Position = position;
        InitialPosition = initialPosition;
        TurnOfLastMovement = turnOfLastMovement;
    }

    public virtual Piece Clone()
    {
        return new Piece(Name, Color, new Position(Position.Row, Position.Column), InitialPosition, TurnOfLastMovement);
    }

    public virtual HashSet<int> PossibleMovement(Piece[] pieces, int turnCount)
    {
        return new HashSet<int>();
    }

    public virtual HashSet<int> PossibleMovementAfter (Piece[] board, int turnCount)
    {
        Piece[] pieces;
        HashSet<int> possibleMovement = new HashSet<int>();

        Position currentPosition = new Position(Position.Row, Position.Column);

        foreach (int id in PossibleMovement(board, turnCount))
        {
            pieces = board.Select(p => p.Clone()).ToArray();
            pieces[id] = pieces[Position.PositionInTheList(currentPosition)];
            pieces[id].Position = board[id].Position;
            pieces[Position.PositionInTheList(currentPosition)] = new Piece("-", "Empty", currentPosition);

            if (!Verify.VerifyCheck(pieces, turnCount))
            {
                possibleMovement.Add(id);
            }
        }
        return possibleMovement;
    }
}
