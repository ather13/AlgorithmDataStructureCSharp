using System.Collections.Generic;

namespace AlgonDS._11GraphProblems
{
    public class MinIslandSizeProblem
    {
        public int GetMinIslandCount(char[][] grid)
        {
            var visited = new HashSet<string>();
            var minSize = int.MaxValue;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    var size = GetIslandCount(grid, row, col, visited);

                    if (minSize > size && size != 0)
                    {
                        minSize = size;
                    }

                }
            }

            return minSize;
        }

        private int GetIslandCount(char[][] grid, int row, int col, ISet<string> visited)
        {
            

            var inBoundRow = row >= 0 && row < grid.Length;
            var inBoundCol = col >= 0 && col < grid[0].Length;

            if (!inBoundRow || !inBoundCol) return 0;

            if (grid[row][col] == 'W') return 0;

            if (visited.Contains($"{row}-{col}")) return 0;

            visited.Add($"{row}-{col}");

            var size = 1;
            size += GetIslandCount(grid, row + 1, col, visited);
            size += GetIslandCount(grid, row - 1, col, visited);
            size += GetIslandCount(grid, row, col + 1, visited);
            size += GetIslandCount(grid, row, col - 1, visited);

            return size;
        }
    }
}
