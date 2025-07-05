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
				if (turn == 0)
				{
					System.Console.WriteLine("É a vez das Brancas");
				}
				else
				{
					System.Console.WriteLine("É a vez das Pretas");
				}
				
				System.Console.WriteLine("Escolha a posição da peça que deseja movimentar (Ex.: e4): ");
				string piecePosition;

				while (true)
				{
					piecePosition = Console.ReadLine();
					if (ValidPieceSelection(piecePosition))
					{
						System.Console.WriteLine("ok");
						break;
					}
					System.Console.WriteLine("Opção invalida!\nEscolha a posição da peça que deseja movimentar (Ex.: e4): ");
				}


				System.Console.WriteLine("Agora selecione a casa que deseja avançar (Ex.: e4): ");
				string futurePosition;

				while (true)
				{
					futurePosition = Console.ReadLine();
					if (ValidSquareSelection(futurePosition))
					{
						System.Console.WriteLine("ok");
						break;
					}
					System.Console.WriteLine("Opção invalida!\nAgora selecione a casa que deseja avançar (Ex.: e4): ");
				}
				

				break;
			}
        }

		static bool ValidPieceSelection(string input)
		{
			if (input.Length != 2)
			{
				return false;
			}
			if (input.StartsWith('a') || input.StartsWith('b') || input.StartsWith('c') || input.StartsWith('d') || input.StartsWith('e') || input.StartsWith('f') || input.StartsWith('g') || input.StartsWith('h'))
			{

			}
			return false;
		}

		static bool ValidSquareSelection(string input)
		{
			if (input.Length != 2)
			{
				return false;
			}
			if (input.StartsWith('a') || input.StartsWith('b') || input.StartsWith('c') || input.StartsWith('d') || input.StartsWith('e') || input.StartsWith('f') || input.StartsWith('g') || input.StartsWith('h'))
			{

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
