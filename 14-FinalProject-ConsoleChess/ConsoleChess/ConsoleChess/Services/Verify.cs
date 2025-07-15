using System;
using System.Linq;
using ConsoleChess.Board;
using ConsoleChess.Pieces;

namespace ConsoleChess.Services;

public static class Verify
{
    public static bool VerifyCheck(Piece[] pieces, int turnCount)
    {
        if (turnCount % 2 != 0)
        {
            var enemyPieces = pieces.Where(p => p.Color == "Black");
            int kingSquare = Position.PositionInTheList(pieces.FirstOrDefault(p => p.Color == "White" && p.Name == "K")!.Position);
            HashSet<int> squaresUnderAttack = new HashSet<int>();
            foreach (var piece in enemyPieces)
            {
                HashSet<int> possibleMovement = piece.PossibleMovement(pieces, turnCount);

                if (possibleMovement.Count > 0)
                {
                    foreach (int position in possibleMovement)
                    {
                        squaresUnderAttack.Add(position);
                    }
                }
            }
            return squaresUnderAttack.Contains(kingSquare);
        }
        else
        {
            var enemyPieces = pieces.Where(p => p.Color == "White");
            int kingSquare = Position.PositionInTheList(pieces.FirstOrDefault(p => p.Color == "Black" && p.Name == "K")!.Position);
            HashSet<int> squaresUnderAttack = new HashSet<int>();
            foreach (var piece in enemyPieces)
            {
                HashSet<int> possibleMovement = piece.PossibleMovement(pieces, turnCount);

                if (possibleMovement.Count > 0)
                {
                    foreach (int position in possibleMovement)
                    {
                        squaresUnderAttack.Add(position);
                    }
                }
            }
            return squaresUnderAttack.Contains(kingSquare);
        }
    }
}
