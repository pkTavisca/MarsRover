using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        public int XCordinate { get; }
        public int YCordinate { get; }

        public Rover(int xCordinate = 0, int yCordinate = 0)
        {
            XCordinate = xCordinate;
            YCordinate = yCordinate;
        }
    }
}
