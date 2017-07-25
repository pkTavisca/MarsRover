using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Coordinate
    {
        public int X { get; }
        public int Y { get; }

        public Coordinate(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        override
        public string ToString()
        {
            return string.Format("{0} {1}", X, Y);
        }
    }
}
