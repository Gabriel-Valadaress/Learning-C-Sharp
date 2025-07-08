using System.Runtime.ConstrainedExecution;
using ConsoleChess.Board;
using ConsoleChess.Pieces;

namespace ConsoleChess
{
    public class Program
    {
		static void Main(string[] args)
		{
			Piece[] pieces = InitialPosition();
			int turn = 0;

			while (true)
			{
				Console.Clear();
				Screen.ShowBoard(pieces);
				string color;
				if (turn == 0)
				{
					System.Console.WriteLine("É a vez das Brancas");
					color = "White";
				}
				else
				{
					System.Console.WriteLine("É a vez das Pretas");
					color = "Black";
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
				Screen.ShowBoardAfter(pieces, positionInTheArray);
				System.Console.WriteLine("Agora selecione a casa que deseja avançar (Ex.: e4).\nPara voltar digite 'voltar': ");

				string futurePosition;
				int futurePositionInTheArray;
				int futureColumn;
				int futureRow;
				while (true)
				{
					futurePosition = Console.ReadLine()!;
					if (futurePosition.ToLower() == "voltar")
					{
						break;
					}
					if (ValidSquareSelection(futurePosition, pieces, oldRow, oldColumn))
					{
						futureColumn = char.ToLower(futurePosition[0]) - 'a' + 1;
						futureRow = char.ToLower(futurePosition[1]) - 48;
						futurePositionInTheArray = Position.PositionInTheList(new Position(futureRow, futureColumn));
						pieces[futurePositionInTheArray] = pieces[positionInTheArray];
						pieces[futurePositionInTheArray].Position = new Position(futureRow, futureColumn);
						pieces[positionInTheArray] = new Piece("-", "Empty", new Position(oldRow, oldColumn));
						if (turn == 0)
						{
							turn = 1;
						}
						else
						{
							turn = 0;
						}
						break;
					}
					Console.Clear();
					Screen.ShowBoardAfter(pieces, positionInTheArray);
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

		static bool ValidSquareSelection(string input, Piece[] pieces, int initialRow, int initialColumn)
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

				if (pieces[(initialRow - 1) * 8 + (initialColumn - 1)].PossibleMovement(pieces).Contains(new Position(rowNumber, columnNumber)))
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
