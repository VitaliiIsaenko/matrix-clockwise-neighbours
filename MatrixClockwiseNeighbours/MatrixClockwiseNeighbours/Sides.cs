using System;

namespace MatrixClockwiseNeighbours
{
    public enum Sides
    {
        Up,
        UpRight,
        Right,
        DownRight,
        Down,
        DownLeft,
        Left,
        UpLeft
    }

    public static class SidesExtension
    {
        public static Sides NextPrio(this Sides side)
        {
            if (Enum.IsDefined(typeof(Sides), side + 1))
            {
                return side + 1;
            }

            return 0;
        }
    }
}