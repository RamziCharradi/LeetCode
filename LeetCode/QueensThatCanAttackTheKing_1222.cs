using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class QueensThatCanAttackTheKing_1222
    {
		public static IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king)
		{

			bool[,] board = new bool[8, 8];
			List<IList<int>> result = new List<IList<int>>();

			for (int i = 0; i < queens.Length; i++)
			{
				board[queens[i][0], queens[i][1]] = true;
			}


			int x = king[0];
			int y = king[1];

			// right
			for (int i = x + 1; i < 8; i++)
			{
				if (board[i, y])
				{
					result.Add(new List<int>() { i, y });
					break;
				}
			}

			// left
			for (int i = x - 1; i >= 0; i--)
			{
				if (board[i, y])
				{
					result.Add(new List<int>() { i, y });
					break;
				}
			}

			// top
			for (int i = y + 1; i < 8; i++)
			{
				if (board[x, i])
				{
					result.Add(new List<int>() { x, i });
					break;
				}
			}

			// bottom
			for (int i = y - 1; i >= 0; i--)
			{
				if (board[x, i])
				{
					result.Add(new List<int>() { x, i });
					break;
				}
			}


			// diagonal top left
			for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
			{
				if (board[i, j])
				{
					result.Add(new List<int>() { i, j });
					break;
				}
			}

			// diagonal top right
			for (int i = x - 1, j = y + 1; i >= 0 && j < 8; i--, j++)
			{
				if (board[i, j])
				{
					result.Add(new List<int>() { i, j });
					break;
				}
			}

			// diagonal bottom left
			for (int i = x + 1, j = y - 1; i < 8 && j >= 0; i++, j--)
			{
				if (board[i, j])
				{
					result.Add(new List<int>() { i, j });
					break;
				}
			}

			// diagonal bottom right
			for (int i = x + 1, j = y + 1; i < 8 && j < 8; i++, j++)
			{
				if (board[i, j])
				{
					result.Add(new List<int>() { i, j });
					break;
				}
			}
			return result;

		}
	}
}
