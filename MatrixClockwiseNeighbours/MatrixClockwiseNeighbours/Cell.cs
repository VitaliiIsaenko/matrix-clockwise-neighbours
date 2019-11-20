using System.Collections.Generic;

namespace MatrixClockwiseNeighbours
{
    public class Cell
    {
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            Neighbours = new Dictionary<Sides, Cell>();
        }
        public int X { get; set; }
        public int Y { get; set; }
        public Dictionary<Sides, Cell> Neighbours { get; set; }
    }
}