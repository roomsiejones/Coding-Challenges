namespace RobotInAGrid
{
    public class Solution
    {
        public List<RobotPosition> CreatePath(int[,] grid)
        {
            List<RobotPosition> offLimitPosition = new List<RobotPosition>();
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        offLimitPosition.Add(new RobotPosition(i, j));
                    }
                }
            }

            List<RobotPosition> pathWayPoints = new List<RobotPosition>();
            if (ValidPath(grid, grid.GetLength(0) - 1, grid.GetLength(1) - 1, pathWayPoints, offLimitPosition))
            {
                return pathWayPoints;
            }

            throw new Exception("There is no path! Robot shall not pass!");
        }

        private Boolean ValidPath(int[,] grid, int row, int col, List<RobotPosition> pathWayPoints, List<RobotPosition> offLimitPosition)
        {
            if (row == 0 && col == 0)
            {
                pathWayPoints.Add(new RobotPosition(row, col));
                return true;
            }

            if (row < grid.GetLength(0) && col < grid.GetLength(1) && row >= 0 && col >= 0)
            {
                if (!DoesContain(offLimitPosition, row, col))
                {
                    if (ValidPath(grid, row - 1, col, pathWayPoints, offLimitPosition))
                    {
                        pathWayPoints.Add(new RobotPosition(row, col));
                        return true;
                    }
                    else if (ValidPath(grid, row, col - 1, pathWayPoints, offLimitPosition))
                    {
                        pathWayPoints.Add(new RobotPosition(row, col));
                        return true;
                    }
                }
                offLimitPosition.Add(new RobotPosition(row, col));

            }

            return false;
        }

        private Boolean DoesContain(List<RobotPosition> checkList, int row, int col)
        {
            foreach (var item in checkList)
            {
                if (item.Row == row && item.Col == col)
                {
                    return true;
                }
            }

            return false;
        }
    }

    
}