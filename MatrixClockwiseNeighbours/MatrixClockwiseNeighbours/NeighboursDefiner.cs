using System.Collections.Generic;
using System.Linq;

namespace MatrixClockwiseNeighbours
{
    public class NeighboursDefiner
    {
        public List<Cell> GetNeighboursClockwise(Cell cell)
        {
            var current = cell.Neighbours.FirstOrDefault(n => n.Value == null);

            var prioratizedSides = new List<Sides>();
            prioratizedSides.Add(current.Key);
            for (int i = 0; i < typeof(Sides).GetEnumValues().Length; i++)
            {
                if (!prioratizedSides.Contains(prioratizedSides.Last().NextPrio()))
                {
                    prioratizedSides.Add(prioratizedSides.Last().NextPrio());
                }
            }

            var clockwiseNeighbours = new List<Cell>();

            foreach (var side in prioratizedSides)
            {
                clockwiseNeighbours.Add(cell.Neighbours.FirstOrDefault(n => n.Key == side).Value);
            }

            clockwiseNeighbours.RemoveAll(cn => cn == null);

            return clockwiseNeighbours;
        }
    }
}