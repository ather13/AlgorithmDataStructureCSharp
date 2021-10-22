using System.Collections.Generic;

namespace AlgonDS._11GraphProblems
{
    public class IsLandCountProblem
    {
        public int GetIslandCount(char[][] grid)
        {
            var visited = new HashSet<string>();
            var numOfIslands = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (HasIsland(grid, row, col, visited))
                    {
                        numOfIslands++;
                    }
                }
            }

            return numOfIslands;
        }

        private bool HasIsland(char[][] grid, int row, int col, ISet<string> visited)
        {
            var inBoundRow = row >= 0 && row < grid.Length;
            var inBoundCol = col >= 0 && col < grid[0].Length;

            if (!inBoundRow || !inBoundCol) return false;

            if (grid[row][col] == 'W') return false;

            if (visited.Contains($"{row}-{col}")) return false;

            visited.Add($"{row}-{col}");

            HasIsland(grid, row + 1, col, visited);
            HasIsland(grid, row - 1, col, visited);
            HasIsland(grid, row, col + 1, visited);
            HasIsland(grid, row, col - 1, visited);

            return true;
        }
    }
}
