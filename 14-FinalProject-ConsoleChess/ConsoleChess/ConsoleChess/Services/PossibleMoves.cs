using System;
using ConsoleChess.Pieces;
using ConsoleChess.Board;

namespace ConsoleChess.Services;

public static class PossibleMoves
{
    public static Dictionary<int, HashSet<int>> PossibleMovesSet(Piece[] board, int turnCount)
    {
        Dictionary<int, HashSet<int>> result = new Dictionary<int, HashSet<int>>();

        if (turnCount % 2 != 0)
        {
            foreach (Piece piece in board)
            {
                if (piece.Color == "White" && piece.PossibleMovementAfter(board, turnCount).Count != 0)
                {
                    result.Add(Position.PositionInTheList(piece.Position), piece.PossibleMovementAfter(board, turnCount));
                }
            }

        }
        else
        {
            foreach (Piece piece in board)
            {
                if (piece.Color == "Black" && piece.PossibleMovementAfter(board,turnCount).Count != 0)
                {
                    result.Add(Position.PositionInTheList(piece.Position), piece.PossibleMovementAfter(board,turnCount));
                }
            }
        }

        return result;
    }
}
