using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MatrixClockwiseNeighbours.Tests
{
    public class NeighboursDefinerTests
    {
        [Fact]
        public void DefineNeighbours_LeftTop()
        {
            var matrix = new Matrix().Setup();
            var cell = matrix[0][0];
            
            var neighboursDefiner = new NeighboursDefiner();
            Assert.Equal(new List<(int,int)>{(1,0), (1,1), (0,1)},neighboursDefiner.GetNeighboursClockwise(cell).Select(c => (c.X,c.Y)).ToList());
        }
        
        [Fact]
        public void DefineNeighbours_RightTop()
        {
            var matrix = new Matrix().Setup();
            var cell = matrix[0][2];
            
            var neighboursDefiner = new NeighboursDefiner();
            Assert.Equal(new List<(int,int)>{(0,1), (1,1), (1,2)},neighboursDefiner.GetNeighboursClockwise(cell).Select(c => (c.X,c.Y)).ToList());
        }
    }
}