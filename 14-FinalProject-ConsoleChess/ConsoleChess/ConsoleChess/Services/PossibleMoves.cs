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
                if (piece.Color == "White" && piece.PossibleMovement(board, turnCount) != null)
                {
                    result.Add(Position.PositionInTheList(piece.Position), piece.PossibleMovement(board, turnCount));
                }
            }

        }
        else
        {
            foreach (Piece piece in board)
            {
                if (piece.Color == "Black" && piece.PossibleMovement(board,turnCount) != null)
                {
                    result.Add(Position.PositionInTheList(piece.Position), piece.PossibleMovement(board,turnCount));
                }
            }
        }

        return result;
    }
}
