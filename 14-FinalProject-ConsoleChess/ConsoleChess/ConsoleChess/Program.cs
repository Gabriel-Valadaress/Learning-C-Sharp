using System.Runtime.ConstrainedExecution;
using ConsoleChess.Board;
using ConsoleChess.Pieces;
using ConsoleChess.Services;

namespace ConsoleChess
{
    public class Program
    {
		static void Main(string[] args)
		{
			Piece[] pieces = InitialPosition();
			int turnCount = 1;

			while (true)
			{
				Console.Clear();
				Screen.ShowBoard(pieces);
				string color;
				if (turnCount % 2 != 0)
				{
					System.Console.WriteLine($"Turno {turnCount}: É a vez das Brancas");
					color = "White";
				}
				else
				{
					System.Console.WriteLine($"Turno {turnCount}: É a vez das Pretas");
					color = "Black";
				}

				//Verificar se está em posição de check, se sim tem que defender
				if (Verify.VerifyCheck(pieces, turnCount))
				{
					System.Console.WriteLine("Está em cheque");
				}

				System.Console.WriteLine("Escolha a posição da peça que deseja movimentar (Ex.: e4): ");
				string piecePosition;
				int positionInTheArray;
				int oldRow;
				int oldColumn;

				while (true)
				{
					piecePosition = Console.ReadLine()!;
					if (ValidPieceSelection(piecePosition, pieces, color))
					{
						oldColumn = char.ToLower(piecePosition[0]) - 'a' + 1;
						oldRow = char.ToLower(piecePosition[1]) - 48;
						positionInTheArray = Position.PositionInTheList(new Position(oldRow, oldColumn));
						break;
					}
					Console.Clear();
					Screen.ShowBoard(pieces);
					System.Console.WriteLine("Opção invalida!\nEscolha a posição da peça que deseja movimentar (Ex.: e4): ");
				}

				Console.Clear();
				Screen.ShowBoardAfter(pieces, positionInTheArray, turnCount);
				System.Console.WriteLine("Agora selecione a casa que deseja avançar (Ex.: e4).\nPara voltar digite 'voltar': ");

				string futurePosition;
				int futurePositionInTheArray;
				int futureColumn;
				int futureRow;

				//Verificar se mexer a peça não vai resultar em um check descoberto

				while (true)
				{
					futurePosition = Console.ReadLine()!;
					if (futurePosition.ToLower() == "voltar")
					{
						break;
					}
					if (ValidSquareSelection(futurePosition, pieces, oldRow, oldColumn, turnCount))
					{
						futureColumn = char.ToLower(futurePosition[0]) - 'a' + 1;
						futureRow = char.ToLower(futurePosition[1]) - 48;
						futurePositionInTheArray = Position.PositionInTheList(new Position(futureRow, futureColumn));

						if ((futureRow == 8 || futureRow == 1) && pieces[positionInTheArray].Name == "P")
						{
							System.Console.Write("Promoção do peão.\n1 - Dama\n2 - Bispo\n3 - Cavalo\n4 - Torre\nEscolha a opção desejada: ");
							string promotionOption = Console.ReadLine()!;
							while (true)
							{
								switch (promotionOption)
								{
									case "1":
										pieces[futurePositionInTheArray] = new Queen("Q", pieces[positionInTheArray].Color, new Position(futureRow, futureColumn));
										break;
									case "2":
										pieces[futurePositionInTheArray] = new Bishop("B", pieces[positionInTheArray].Color, new Position(futureRow, futureColumn));
										break;
									case "3":
										pieces[futurePositionInTheArray] = new Knight("N", pieces[positionInTheArray].Color, new Position(futureRow, futureColumn));
										break;
									case "4":
										pieces[futurePositionInTheArray] = new Rook("R", pieces[positionInTheArray].Color, new Position(futureRow, futureColumn));
										break;
									default:
										Console.Clear();
										Screen.ShowBoardAfter(pieces, positionInTheArray, turnCount);
										Console.Write("Opção inválida\nPromoção do peão.\n1 - Dama\n2 - Bispo\n3 - Cavalo\n4 - Torre\nEscolha a opção desejada: ");
										promotionOption = Console.ReadLine()!;
										continue;
								}
								break;
							}
						}
						else if (pieces[positionInTheArray].Name == "K" &&
						futureColumn - pieces[positionInTheArray].Position.Column == 2 &&
						futureColumn > pieces[positionInTheArray].Position.Column)
						{
							pieces[futurePositionInTheArray] = pieces[positionInTheArray];
							pieces[futurePositionInTheArray].Position = new Position(futureRow, futureColumn);
							pieces[Position.PositionInTheList(new Position(futureRow, futureColumn - 1))] = pieces[Position.PositionInTheList(new Position(futureRow, futureColumn + 1))];
							pieces[Position.PositionInTheList(new Position(futureRow, futureColumn + 1))] = pieces[positionInTheArray] = new Piece("-", "Empty", new Position(futureRow, futureColumn + 1));
						}
						else if (pieces[positionInTheArray].Name == "K" &&
						futureColumn - pieces[positionInTheArray].Position.Column == -2 &&
						futureColumn < pieces[positionInTheArray].Position.Column)
						{
							pieces[futurePositionInTheArray] = pieces[positionInTheArray];
							pieces[futurePositionInTheArray].Position = new Position(futureRow, futureColumn);
							pieces[Position.PositionInTheList(new Position(futureRow, futureColumn + 1))] = pieces[Position.PositionInTheList(new Position(futureRow, futureColumn - 2))];
							pieces[Position.PositionInTheList(new Position(futureRow, futureColumn - 2))] = pieces[positionInTheArray] = new Piece("-", "Empty", new Position(futureRow, futureColumn - 2));
						}
						else if (pieces[positionInTheArray].Name == "P" &&
						futureColumn != pieces[positionInTheArray].Position.Column &&
						pieces[futurePositionInTheArray].Name == "-")
						{
							pieces[futurePositionInTheArray] = pieces[positionInTheArray];
							pieces[futurePositionInTheArray].Position = new Position(futureRow, futureColumn);
							pieces[(oldRow - 1) * 8 + (futureColumn - 1)] = new Piece("-", "Empty", new Position(oldRow, futureColumn));
						}
						else
						{
							pieces[futurePositionInTheArray] = pieces[positionInTheArray];
							pieces[futurePositionInTheArray].Position = new Position(futureRow, futureColumn);
						}
						pieces[positionInTheArray] = new Piece("-", "Empty", new Position(oldRow, oldColumn));
						pieces[futurePositionInTheArray].InitialPosition = false;
						pieces[futurePositionInTheArray].TurnOfLastMovement = turnCount;

						//Verificar check-mate
						turnCount++;
						break;
					}
					Console.Clear();
					Screen.ShowBoardAfter(pieces, positionInTheArray, turnCount);
					System.Console.WriteLine("Opção invalida!\nAgora selecione a casa que deseja avançar (Ex.: e4).\nPara voltar digite 'voltar': ");
				}
			}
        }

		static bool ValidPieceSelection(string input, Piece[] pieces, string color)
		{
			if (string.IsNullOrWhiteSpace(input) || input.Length != 2)
			{
				return false;
			}

			char row = char.ToLowerInvariant(input[0]);
			char column = input[1];

			bool rowOk = row >= 'a' && row <= 'h';
			bool columnOk = column >= '1' && column <= '8';

			if (rowOk && columnOk)
			{
				int columnNumber = char.ToLower(row)  - 'a' + 1;
				int rowNumber = column - 48;

				string pieceColor = pieces[(Position.PositionInTheList(new Position(rowNumber, columnNumber)))].Color;
				if (pieceColor == color)
				{
					return true;
				}
				return false;
			}
			else
			{
				return false;
			}
		}

		static bool ValidSquareSelection(string input, Piece[] pieces, int initialRow, int initialColumn, int turnCount)
		{
			if (string.IsNullOrWhiteSpace(input) || input.Length != 2)
			{
				return false;
			}

			char row = char.ToLowerInvariant(input[0]);
			char column = input[1];

			bool rowOk = row >= 'a' && row <= 'h';
			bool columnOk = column >= '1' && column <= '8';

			if (rowOk && columnOk)
			{
				int columnNumber = char.ToLower(row)  - 'a' + 1;
				int rowNumber = column - 48;

				if (pieces[(initialRow - 1) * 8 + (initialColumn - 1)].PossibleMovementAfter(pieces, turnCount).Contains(Position.PositionInTheList(new Position(rowNumber, columnNumber))))
				{
					return true;
				}
			}

			return false;
        }

        static Piece[] InitialPosition()
		{
			Piece[] pieces = new Piece[64];
			pieces[0] = new Rook("R", "White", new Position(1, 1));
			pieces[1] = new Knight("N", "White", new Position(1, 2));
			pieces[2] = new Bishop("B", "White", new Position(1, 3));
			pieces[3] = new Queen("Q", "White", new Position(1, 4));
			pieces[4] = new King("K", "White", new Position(1, 5));
			pieces[5] = new Bishop("B", "White", new Position(1, 6));
			pieces[6] = new Knight("N", "White", new Position(1, 7));
			pieces[7] = new Rook("R", "White", new Position(1, 8));

			for (int i = 0; i < 8; i++)
			{
				pieces[8 + i] = new Pawn("P", "White", new Position(2, i + 1));
			}

			int count = 16;

			for (int i = 3; i < 7; i++)
			{
				for (int j = 1; j <= 8; j++)
				{
					pieces[count] = new Piece("-", "Empty", new Position(i, j));
					count++;
				}
			}

			for (int i = 0; i < 8; i++)
			{
				pieces[48 + i] = new Pawn("P", "Black", new Position(7, i + 1));
			}

			pieces[56] = new Rook("R", "Black", new Position(8, 1));
			pieces[57] = new Knight("N", "Black", new Position(8, 2));
			pieces[58] = new Bishop("B", "Black", new Position(8, 3));
			pieces[59] = new Queen("Q", "Black", new Position(8, 4));
			pieces[60] = new King("K", "Black", new Position(8, 5));
			pieces[61] = new Bishop("B", "Black", new Position(8, 6));
			pieces[62] = new Knight("N", "Black", new Position(8, 7));
			pieces[63] = new Rook("R", "Black", new Position(8, 8));

			return pieces;
		}
    }
}
