using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover : IRover
    {
        public int XCordinate { get; private set; }
        public int YCordinate { get; private set; }
        public Direction FacingDirection { get; private set; }
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
            switch (direction)
            {
                case Direction.North:
                    return MoveUp();
                case Direction.South:
                    return MoveDown();
                case Direction.East:
                    return MoveRight();
                case Direction.West:
                    return MoveLeft();
                default: return false;
            }
        }

        private bool MoveUp()
        {
            FacingDirection = Direction.North;
            if (mars.IsPositionInsidePlanet(XCordinate, YCordinate - 1))
            {
                YCordinate--;
                return true;
            }
            else return false;
        }

        private bool MoveDown()
        {
            FacingDirection = Direction.South;
            if (mars.IsPositionInsidePlanet(XCordinate, YCordinate + 1))
            {
                YCordinate++;
                return true;
            }
            else return false;
        }

        private bool MoveLeft()
        {
            FacingDirection = Direction.West;
            if (mars.IsPositionInsidePlanet(XCordinate, XCordinate - 1))
            {
                XCordinate--;
                return true;
            }
            else return false;
        }

        private bool MoveRight()
        {
            FacingDirection = Direction.East;
            if (mars.IsPositionInsidePlanet(XCordinate, YCordinate + 1))
            {
                XCordinate++;
                return true;
            }
            else return false;
        }
    }
}
