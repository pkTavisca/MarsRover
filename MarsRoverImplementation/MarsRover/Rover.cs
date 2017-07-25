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
        public Pole FacingDirection { get; private set; }
        private PlanetMars mars;

        public Rover(PlanetMars mars, int xCordinate = 0, int yCordinate = 0, Pole pole = Pole.North)
        {
            XCordinate = xCordinate;
            YCordinate = yCordinate;
            this.mars = mars;
            FacingDirection = pole;
        }

        public bool Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Back:
                    TurnBack();
                    break;
                case Direction.Left:
                    TurnLeft();
                    break;
                case Direction.Right:
                    TurnRight();
                    break;
            }
            return MoveForward();
        }

        void TurnLeft()
        {
            int pole = (int)FacingDirection;
            pole += 1;
            pole %= 4;
            FacingDirection = (Pole)pole;
        }
        void TurnRight()
        {
            int pole = (int)FacingDirection;
            pole += 3;
            pole %= 4;
            FacingDirection = (Pole)pole;
        }
        void TurnBack()
        {
            int pole = (int)FacingDirection;
            pole += 2;
            pole %= 4;
            FacingDirection = (Pole)pole;
        }

        private bool MoveForward()
        {
            if (FacingDirection == Pole.North)
            {
                if (mars.IsPositionInsidePlanet(XCordinate, YCordinate - 1))
                {
                    YCordinate--;
                    return true;
                }
                return false;
            }
            else if (FacingDirection == Pole.South)
            {
                if (mars.IsPositionInsidePlanet(XCordinate, YCordinate + 1))
                {
                    YCordinate++;
                    return true;
                }
                return false;
            }
            else if (FacingDirection == Pole.West)
            {
                if (mars.IsPositionInsidePlanet(XCordinate - 1, YCordinate))
                {
                    XCordinate--;
                    return true;
                }
                return false;
            }
            else if (FacingDirection == Pole.East)
            {
                if (mars.IsPositionInsidePlanet(XCordinate + 1, YCordinate))
                {
                    XCordinate++;
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
