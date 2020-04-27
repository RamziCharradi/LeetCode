using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class CheckIfItIsaAStraightLine_1232
    {
		public static bool CheckStraightLine(int[][] coordinates)
		{

			if (coordinates == null || coordinates.Length == 1)
			{
				return true;
			}

			int x1 = coordinates[0][0];
			int y1 = coordinates[0][1];

			int x2, y2, x3, y3;

			for (int i = 1; i < coordinates.Length - 1; i++)
			{
				x2 = coordinates[i][0];
				y2 = coordinates[i][1];

				x3 = coordinates[i + 1][0];
				y3 = coordinates[i + 1][1];

				int a = (y2 - y1) * (x3 - x2);
				int b = (y3 - y2) * (x2 - x1);

				if (a != b)
				{
					return false;
				}

				x2 = x1;
				y2 = y1;

				x1 = x2;
				y1 = y2;
			}

			return true;

		}
	}
}
