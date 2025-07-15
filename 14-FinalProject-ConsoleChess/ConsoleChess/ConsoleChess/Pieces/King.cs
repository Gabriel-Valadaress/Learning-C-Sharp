using System;
using ConsoleChess.Board;
using ConsoleChess.Services;

namespace ConsoleChess.Pieces;

public class King : Piece
{
    public King(string name, string color, Position position) : base(name, color, position) { }

    public King(string name, string color, Position position, bool initialPosition, int turnOfLastMovement) : base(name, color, position, initialPosition, turnOfLastMovement) { }

    public override Piece Clone()
    {
        return new King(Name, Color, new Position(Position.Row, Position.Column), InitialPosition, TurnOfLastMovement);
    }

    public override HashSet<int> PossibleMovement(Piece[] pieces, int turnCount)
    {
        HashSet<int> possibleMovement = new HashSet<int>();

        if (Position.Row > 1)
        {
            if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column)));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Color == "Black")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column)));
                }
            }
            else
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Color == "White")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column)));
                }
            }

            if (Position.Column > 1)
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                    }
                }
                else
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                    }
                }

                if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column - 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column - 1)));
                    }
                }
                else
                {
                    if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column - 1)));
                    }
                }
            }

            if (Position.Column < 8)
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                    }
                }
                else
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                    }
                }

                if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column + 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column + 1)));
                    }
                }
                else
                {
                    if (pieces[((Position.Row - 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row - 1, Position.Column + 1)));
                    }
                }
            }

            if (Position.Row < 8)
            {
                if (Position.Column > 1)
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                    }
                    else if (Color == "White")
                    {
                        if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                        {
                            possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                        }
                    }
                    else
                    {
                        if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                        {
                            possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                        }
                    }
                }

                if (Position.Column < 8)
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                    }
                    else if (Color == "White")
                    {
                        if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                        {
                            possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                        }
                    }
                    else
                    {
                        if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                        {
                            possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                        }
                    }
                }

                if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                }
                else if (Color == "White")
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                    }
                }
                else
                {
                    if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                    }
                }
            }
        }
        else
        {
            if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Name == "-")
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
            }
            else if (Color == "White")
            {
                if (pieces[((Position.Row + 1) - 1) * 8 + (Position.Column - 1)].Color == "Black")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                }
            }
            else
            {
                if (pieces[((Position.Row - 1) - 1) * 8 + (Position.Column - 1)].Color == "White")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column)));
                }
            }

            if (Position.Column > 1)
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                    }
                }
                else
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 1)));
                    }
                }

                if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                    }
                }
                else
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column - 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column - 1)));
                    }
                }
            }

            if (Position.Column < 8)
            {
                if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                    }
                }
                else
                {
                    if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 1)));
                    }
                }

                if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-")
                {
                    possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                }
                else if (Color == "White")
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "Black")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                    }
                }
                else
                {
                    if (pieces[((Position.Row + 1) - 1) * 8 + ((Position.Column + 1) - 1)].Color == "White")
                    {
                        possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row + 1, Position.Column + 1)));
                    }
                }
            }
        }

        if (InitialPosition == true)
        {
            if (pieces[(Position.Row - 1) * 8 + ((Position.Column + 1) - 1)].Name == "-" &&
            pieces[(Position.Row - 1) * 8 + ((Position.Column + 2) - 1)].Name == "-" &&
            pieces[(Position.Row - 1) * 8 + ((Position.Column + 3) - 1)].InitialPosition == true)
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column + 2)));
            }

            if (pieces[(Position.Row - 1) * 8 + ((Position.Column - 1) - 1)].Name == "-" &&
            pieces[(Position.Row - 1) * 8 + ((Position.Column - 2) - 1)].Name == "-" &&
            pieces[(Position.Row - 1) * 8 + ((Position.Column - 3) - 1)].Name == "-" &&
            pieces[(Position.Row - 1) * 8 + ((Position.Column - 4) - 1)].InitialPosition == true)
            {
                possibleMovement.Add(Position.PositionInTheList(new Position(Position.Row, Position.Column - 2)));
            }
        }

        return possibleMovement;
    }
    
    public override HashSet<int> PossibleMovementAfter (Piece[] board, int turnCount)
    {
        Piece[] pieces;
        HashSet<int> possibleMovement = new HashSet<int>();

        Position currentPosition = new Position(Position.Row, Position.Column);
        int currentColumn = currentPosition.Column;
        int currentId = Position.PositionInTheList(currentPosition);

        foreach (int id in PossibleMovement(board, turnCount))
        {
            if (board[id].Position.Column - currentColumn > 1)
            {
                //Rock para direita
                IEnumerable<Piece> enemyPieces;
                if (turnCount % 2 != 0)
                {
                    enemyPieces = board.Where(p => p.Color == "Black");
                }
                else
                {
                    enemyPieces = board.Where(p => p.Color == "White");
                }

                HashSet<int> squaresUnderAttack = new HashSet<int>();
                foreach (var piece in enemyPieces)
                {
                    HashSet<int> possibleMove = piece.PossibleMovement(board, turnCount);

                    if (possibleMove.Count > 0)
                    {
                        foreach (int position in possibleMove)
                        {
                            squaresUnderAttack.Add(position);
                        }
                    }
                }
                if (!squaresUnderAttack.Contains(currentId) && !squaresUnderAttack.Contains(currentId + 1) && !squaresUnderAttack.Contains(currentId + 2))
                {
                    possibleMovement.Add(id);
                }
            }
            else if (board[id].Position.Column - currentColumn < 1)
            {
                IEnumerable<Piece> enemyPieces;
                if (turnCount % 2 != 0)
                {
                    enemyPieces = board.Where(p => p.Color == "Black");
                }
                else
                {
                    enemyPieces = board.Where(p => p.Color == "White");
                }

                HashSet<int> squaresUnderAttack = new HashSet<int>();
                foreach (var piece in enemyPieces)
                {
                    HashSet<int> possibleMove = piece.PossibleMovement(board, turnCount);

                    if (possibleMove.Count > 0)
                    {
                        foreach (int position in possibleMove)
                        {
                            squaresUnderAttack.Add(position);
                        }
                    }
                }
                if (!squaresUnderAttack.Contains(currentId) && !squaresUnderAttack.Contains(currentId - 1) && !squaresUnderAttack.Contains(currentId - 2))
                {
                    possibleMovement.Add(id);
                }
            }
            else
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

        }
        return possibleMovement;
    }
}
