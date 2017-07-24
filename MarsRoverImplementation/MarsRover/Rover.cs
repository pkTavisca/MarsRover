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
        public Direction FacingDirection { get; }
        private PlanetMars mars;

        public Rover(PlanetMars mars, int xCordinate = 0, int yCordinate = 0, Direction direction = Direction.North)
        {
            XCordinate = xCordinate;
            YCordinate = yCordinate;
            this.mars = mars;
            FacingDirection = direction;
        }

        public bool Move(Direction direction)
        {
            return false;
        }

    }
}
