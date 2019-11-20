using System.Collections.Generic;
using System.Linq;

namespace MatrixClockwiseNeighbours
{
    public class Matrix
    {
        public Cell[][] Setup()
        {
            Cell[][] matrix = new Cell[3][];
            matrix[0] = new Cell[3];
            matrix[1] = new Cell[3];
            matrix[2] = new Cell[3];
            
            var cells = new List<Cell>()
            {
                new Cell(0, 0),
                new Cell(0, 1),
                new Cell(0, 2),
                new Cell(1, 0),
                new Cell(1, 1),
                new Cell(1, 2),
                new Cell(2, 0),
                new Cell(2, 1),
                new Cell(2, 2),
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var cell = cells.Single(c => c.X == i && c.Y == j);
                    cell.Neighbours.Add(Sides.Up, cells.SingleOrDefault(c => c.X == i && c.Y == j - 1));
                    cell.Neighbours.Add(Sides.UpRight, cells.SingleOrDefault(c => c.X == i + 1 && c.Y == j - 1));
                    cell.Neighbours.Add(Sides.Right, cells.SingleOrDefault(c => c.X == i + 1 && c.Y == j));
                    cell.Neighbours.Add(Sides.DownRight, cells.SingleOrDefault(c => c.X == i + 1 && c.Y == j + 1));
                    cell.Neighbours.Add(Sides.Down, cells.SingleOrDefault(c => c.X == i && c.Y == j + 1));
                    cell.Neighbours.Add(Sides.DownLeft, cells.SingleOrDefault(c => c.X == i - 1 && c.Y == j + 1));
                    cell.Neighbours.Add(Sides.Left, cells.SingleOrDefault(c => c.X == i - 1 && c.Y == j));
                    cell.Neighbours.Add(Sides.UpLeft, cells.SingleOrDefault(c => c.X == i - 1 && c.Y == j - 1));
                    matrix[i][j] = cell;
                }
            }

            return matrix;
        }
    }
}